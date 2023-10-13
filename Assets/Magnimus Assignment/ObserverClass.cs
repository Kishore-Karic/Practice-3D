using System;

namespace MagnimusAssignment
{
    public class ObserverClass : GenericSingleton<ObserverClass>
    {
        public event Action onEnemyDead;

        public void OnEnemyDead()
        {
            onEnemyDead?.Invoke();
        }
    }
}