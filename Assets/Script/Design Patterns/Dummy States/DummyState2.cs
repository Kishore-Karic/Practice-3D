using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyState2 : BaseState
{
    private DummyStateMachine dummyStateMachine;
    public DummyState2(DummyStateMachine _dummyStateMachine)
    {
        dummyStateMachine = _dummyStateMachine;
    }

    public override void OnStart()
    {
        Debug.Log("DummyState2 Start");
    }

    public override void OnUpdate()
    {
        Debug.Log("DummyState2 Update");
    }

    public override void OnEnd()
    {
        Debug.Log("DummyState2 End");
    }
}
