using System;
using System.Collections.Generic;
using UnityEngine;

namespace MagnimusAssignment
{
    [CreateAssetMenu(fileName = "Wave", menuName = "WaveScriptableObject")]
    public class WaveScriptableObject : ScriptableObject
    {
        public List<EnemyTypes> wavesList;
    }

    [Serializable]
    public class EnemyTypes
    {
        public int MeleeEnemy, RangedEnemy;
    }
}