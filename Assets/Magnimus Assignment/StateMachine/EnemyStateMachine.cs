namespace MagnimusAssignment
{
    public class EnemyStateMachine : StateMachine
    {
        public IdleState IdleState { get; private set; }
        public PatrolState PatrolState { get; private set; }
        public ChaseState ChaseState { get; private set; }
        public DeadState DeadState { get; private set; }
        public AttackState AttackState { get; private set; }

        private MeleeAttackState MeleeAttackState;
        private RangedAttackState RangedAttackState;


        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            IdleState = new IdleState(this);
            PatrolState = new PatrolState(this);
            ChaseState = new ChaseState(this);
            DeadState = new DeadState(this);
            AttackState = new AttackState();
            MeleeAttackState = new MeleeAttackState(this);
            RangedAttackState = new RangedAttackState(this);

            SetState(IdleState);
        }

        public void Dead()
        {
            ObserverClass.Instance.OnEnemyDead();
            SetState(DeadState);
        }

        // If AttackState called respective AttackState of this particular will be called
        public void SetAttackState(EnemyType enemyType)
        {
            if(enemyType == EnemyType.MeleeEnemy)
            {
                AttackState = MeleeAttackState;
            }
            else if(enemyType == EnemyType.RangedEnemy)
            {
                AttackState = RangedAttackState;
            }
        }
    }
}