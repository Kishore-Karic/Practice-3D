namespace MagnimusAssignment
{
    public class IdleState : BaseState
    {
        private EnemyStateMachine enemyStateMachine;

        public IdleState(EnemyStateMachine _enemyStateMachine)
        {
            enemyStateMachine = _enemyStateMachine;
        }

        public override void OnStart()
        {

        }

        public override void OnUpdate()
        {
            // can Move to PatrolState, ChaseState, AttackState, DeadState
        }

        public override void OnEnd()
        {

        }
    }
}