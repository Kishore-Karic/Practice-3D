namespace MagnimusAssignment
{
    public class PatrolState : BaseState
    {
        private EnemyStateMachine enemyStateMachine;

        public PatrolState(EnemyStateMachine _enemyStateMachine)
        {
            enemyStateMachine = _enemyStateMachine;
        }

        public override void OnStart()
        {

        }

        public override void OnUpdate()
        {
            // can Move to IdleState, ChaseState, AttackState, DeadState
        }

        public override void OnEnd()
        {

        }
    }
}