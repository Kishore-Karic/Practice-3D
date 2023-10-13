using UnityEngine;

public class StateMachine : MonoBehaviour
{
    protected BaseState currentState;

    protected void SetState(BaseState _baseState)
    {
        currentState?.OnEnd();

        currentState = _baseState;

        currentState?.OnStart();
    }
}
