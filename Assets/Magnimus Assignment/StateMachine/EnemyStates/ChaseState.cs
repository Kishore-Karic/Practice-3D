namespace MagnimusAssignment
{
    public class ChaseState : BaseState
    {
        private EnemyStateMachine enemyStateMachine;

        public ChaseState(EnemyStateMachine _enemyStateMachine)
        {
            enemyStateMachine = _enemyStateMachine;
        }

        public override void OnStart()
        {
            
        }

        public override void OnUpdate()
        {
            // can Move to PatrolState, IdleState, AttackState, DeadState
        }

        public override void OnEnd()
        {
            
        }
    }
}