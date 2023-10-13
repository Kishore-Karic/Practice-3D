using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyState1 : BaseState
{
    private DummyStateMachine dummyStateMachine;
    public DummyState1(DummyStateMachine _dummyStateMachine)
    {
        dummyStateMachine = _dummyStateMachine;
    }

    public override void OnStart()
    {
        Debug.Log("DummyState1 Start");
    }

    public override void OnUpdate()
    {
        Debug.Log("DummyState1 Update");
    }

    public override void OnEnd()
    {
        Debug.Log("DummyState1 End");
    }
}
