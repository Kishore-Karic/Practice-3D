using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticRigidBody : MonoBehaviour
{
    private void Awake()
    {
        
    }
    private void Update()
    {
        transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }
}
