using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MagnimusAssignment
{
    public class EnemyController
    {
        private EnemyModel enemyModel;
        private EnemyView enemyView;
        private EnemyStateMachine enemyStateMachine;

        public EnemyController(EnemyView _enemyView, EnemyType enemyType, List<EnemyView> enemyList)
        {
            GameObject.Instantiate(enemyView);
            enemyList.Add(enemyView);
            enemyView.SetController(this);
            enemyStateMachine = enemyView.enemyStateMachine;
        }
    }
}