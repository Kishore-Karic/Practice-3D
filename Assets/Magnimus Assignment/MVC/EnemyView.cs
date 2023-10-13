using UnityEngine;

namespace MagnimusAssignment
{
    public class EnemyView : MonoBehaviour
    {
        [field: SerializeField] public EnemyStateMachine enemyStateMachine { get; private set; }
        EnemyController enemyController;

        public void SetController(EnemyController _enemyController)
        {
            enemyController = _enemyController;
        }

        public void SetType(EnemyType enemyType)
        {
            enemyStateMachine.SetAttackState(enemyType);
            // here we can change weapons aswell
        }
    }
}