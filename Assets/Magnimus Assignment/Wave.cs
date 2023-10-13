namespace MagnimusAssignment
{
    public class Wave
    {
        public int CurrentEnemyDead;
        public int TotalEnemy { get; private set; }
        public int MeleeEnemy { get; private set; }
        public int RangedEnemy { get; private set; }

        public Wave(int currentED, int meleeE, int rangedE)
        {
            CurrentEnemyDead = currentED;
            MeleeEnemy = meleeE;
            RangedEnemy = rangedE;
            TotalEnemy = MeleeEnemy + RangedEnemy;
        }
    }
}