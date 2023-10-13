using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicRigidBody : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }
}
