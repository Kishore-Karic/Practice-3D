using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyStateMachine : StateMachine
{
    public DummyState1 DummyState1 { get; private set; }
    public DummyState2 DummyState2 { get; private set; }
    public DummyState3 DummyState3 { get; private set; }

    private void Awake()
    {
        Initialize();
    }

    private void Update()
    {
        currentState?.OnUpdate();
    }

    private void Initialize()
    {
        DummyState1 = new DummyState1(this);
        DummyState2 = new DummyState2(this);
        DummyState3 = new DummyState3(this);
    }

    public void ChangeState(int i)
    {
        switch (i)
        {
            case 1:
                SetState(DummyState1);
                break;

            case 2:
                SetState(DummyState2);
                break;

            case 3:
                SetState(DummyState3);
                break;

            default:
                break;
        }
    }
}
