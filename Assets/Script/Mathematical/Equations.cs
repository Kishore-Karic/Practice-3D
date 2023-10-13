using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equations : MonoBehaviour
{
    [SerializeField] private GameObject objectA, objectB;

    public int Speed, Value, Min, Max;
    public bool Rotate, Slerp, Clamp, Lerp, Normalize;

    private Quaternion desiredRotation;
    private float horizontal, vertical;
    List<int> list = new List<int>();
    private void Start()
    {
        desiredRotation = Quaternion.LookRotation(objectA.transform.position - transform.position);

        list.Add(1);
        list.Add(2);
        int count = list.Count;
        Debug.Log("\" " + count);

        list.RemoveAt(count-1);
        Debug.Log("\" " + count);



        if (Clamp)
        {
            Debug.Log(Mathf.Clamp(Value, Min, Max));
        }
    }

    private void Update()
    {
        if (Rotate)
        {
            if (Slerp)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, Speed * Time.deltaTime);
            }
            else
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, Speed * Time.deltaTime);
            }
        }

        if (Lerp)
        {
            transform.position = Vector3.Lerp(transform.position, objectB.transform.position, Speed * Time.deltaTime);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        Vector3 currentPosition = new Vector3(horizontal, 0, vertical);

        if (Normalize)
        {
            currentPosition.Normalize();
        }

        Debug.Log(currentPosition.magnitude);
        transform.Translate(currentPosition * 2 * Time.deltaTime);
    }
}
