namespace MagnimusAssignment
{
     // have functionality for Melee Attack
    public class MeleeAttackState : AttackState
    {
        private EnemyStateMachine enemyStateMachine;

        public MeleeAttackState(EnemyStateMachine _enemyStateMachine)
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