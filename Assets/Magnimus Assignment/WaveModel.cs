using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MagnimusAssignment
{
    public class WaveModel : MonoBehaviour
    {
        public WaveScriptableObject waveSO;
        public List<Wave> totalWaves;

        public void Awake()
        {
            totalWaves = new List<Wave>();

            for (int i = 0; i < waveSO.wavesList.Count; i++)
            {
                totalWaves.Add(new Wave(0, waveSO.wavesList[i].MeleeEnemy, waveSO.wavesList[i].RangedEnemy));
            }
        }
    }
}