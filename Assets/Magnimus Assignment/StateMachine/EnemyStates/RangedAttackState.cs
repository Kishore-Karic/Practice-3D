namespace MagnimusAssignment
{
     // have functionality for Ranged Attack
    public class RangedAttackState : AttackState
    {
        private EnemyStateMachine enemyStateMachine;

        public RangedAttackState(EnemyStateMachine _enemyStateMachine)
        {
            enemyStateMachine = _enemyStateMachine;
        }

        public override void OnStart()
        {

        }

        public override void OnUpdate()
        {
            // can Move to PatrolState, ChaseState, IdleState, DeadState
        }

        public override void OnEnd()
        {

        }
    }
}