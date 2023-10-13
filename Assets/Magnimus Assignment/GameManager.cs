using System.Collections.Generic;
using UnityEngine;

namespace MagnimusAssignment
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private EnemyView enemyView;
        [SerializeField] private WaveModel waveModel;

        List<EnemyView> meleeEnemyList = new List<EnemyView>(), rangedEnemyList = new List<EnemyView>();

        int currentWave = 0;

        private void Awake() 
        { 
            ObserverClass.Instance.onEnemyDead += EnemyDead;
        }

        private void Start()
        {
            SpawnEnemy();
        }

        void SpawnEnemy() 
        {
            int melee = waveModel.totalWaves[currentWave].MeleeEnemy, ranged = waveModel.totalWaves[currentWave].RangedEnemy;

            while(melee != 0)
            {
                new EnemyController(enemyView, EnemyType.MeleeEnemy, meleeEnemyList);
                melee--;
            }

            while(ranged != 0)
            {
                new EnemyController(enemyView, EnemyType.RangedEnemy, rangedEnemyList);
                ranged--;
            }
        }

        private void EnemyDead()
        {
            waveModel.totalWaves[currentWave].CurrentEnemyDead++;

            if (waveModel.totalWaves[currentWave].CurrentEnemyDead == waveModel.totalWaves[currentWave].TotalEnemy)
            {
                StartNextWave();
            }
        }

        void StartNextWave() { currentWave++; SpawnEnemy(); }

        public void ChangeWave(int i)
        {
            currentWave = i;
            List<EnemyView> tempEnemyList = new List<EnemyView>();

            int melee = meleeEnemyList.Count, ranged = rangedEnemyList.Count;

            if(waveModel.totalWaves[currentWave].MeleeEnemy > meleeEnemyList.Count)         // if current melee enemy is less add more according to current wave
            {
                while(melee != waveModel.totalWaves[currentWave].MeleeEnemy)
                {
                    new EnemyController(enemyView, EnemyType.MeleeEnemy, meleeEnemyList);
                    melee++;
                }
            }
            else if(waveModel.totalWaves[currentWave].MeleeEnemy < meleeEnemyList.Count)    // else current melee enemy is more add axcess enemy to temp list and remove from melee list
            {
                while(meleeEnemyList.Count != waveModel.totalWaves[currentWave].MeleeEnemy)
                {
                    tempEnemyList.Add(meleeEnemyList[melee - 1]);
                    meleeEnemyList.RemoveAt(melee - 1);
                    melee--;
                }
            }

            if(waveModel.totalWaves[currentWave].RangedEnemy > rangedEnemyList.Count)       // if current ranged enemy is less add more according to current wave
            {
                int tempListCount = tempEnemyList.Count-1;

                while(ranged != waveModel.totalWaves[currentWave].RangedEnemy)
                {
                    if(tempEnemyList.Count != 0)                                            // first add enemies from temp list
                    {
                        tempEnemyList[tempListCount].SetType(EnemyType.RangedEnemy);
                        rangedEnemyList.Add(tempEnemyList[tempListCount - 1]);
                        tempEnemyList.RemoveAt(tempListCount - 1);
                        tempListCount--;
                    }
                    else                                                                    // still need means create new enemies and add
                    {
                        new EnemyController(enemyView, EnemyType.RangedEnemy, rangedEnemyList);
                    }
                    ranged++;
                }
            }
            else if(waveModel.totalWaves[currentWave].RangedEnemy < rangedEnemyList.Count)  // else if current ranged enemy is more remove excess enemy from ranged list
            {
                while(rangedEnemyList.Count != waveModel.totalWaves[currentWave].RangedEnemy)
                {
                    rangedEnemyList.RemoveAt(ranged - 1);
                    ranged--;
                }
            }
        }
    }
}