using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyState3 : BaseState
{
    private DummyStateMachine dummyStateMachine;
    public DummyState3(DummyStateMachine _dummyStateMachine)
    {
        dummyStateMachine = _dummyStateMachine;
    }

    public override void OnStart()
    {
        Debug.Log("DummyState3 Start");
    }

    public override void OnUpdate()
    {
        Debug.Log("DummyState3 Update");
    }

    public override void OnEnd()
    {
        Debug.Log("DummyState3 End");
    }
}
