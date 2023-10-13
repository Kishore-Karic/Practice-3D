using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : GenericSingleton<Dummy>
{
    [SerializeField] private DummyStateMachine dummyStateMachine;

    public string id = "notu";
    private int i = 1, n = 3, one = 1;

    protected override void Awake()
    {
        Debug.Log("Dummy");
        base.Awake();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dummyStateMachine.ChangeState(i);
            i++;
            if(i > n)
            {
                i = one;
            }
        }
    }
}
