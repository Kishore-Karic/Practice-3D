using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    private int i = 0;

    private void Start()
    {
        Debug.Log("Dummy2  " + Dummy.Instance?.id  + "\"");
        StartCoroutine(Call());
        StartCoroutine(Call2());
        Debug.Log("/\\");
    }

    IEnumerator Call()
    {
        Debug.Log("Call Start");

        while (i < 4)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1.5f);
            i++;
        }

        Debug.Log("Call End");
    }

    IEnumerator Call2()
    {
        Debug.Log("Call2 Start");

        yield return new WaitForSeconds(2);

        Debug.Log("Call2 End");
    }
}
