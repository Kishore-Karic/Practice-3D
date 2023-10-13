namespace MagnimusAssignment
{
    public class DeadState : BaseState
    {
        private EnemyStateMachine enemyStateMachine;

        public DeadState(EnemyStateMachine _enemyStateMachine)
        {
            enemyStateMachine = _enemyStateMachine;
        }

        public override void OnStart()
        {

        }

        public override void OnUpdate()
        {
            
        }

        public override void OnEnd()
        {

        }
    }
}