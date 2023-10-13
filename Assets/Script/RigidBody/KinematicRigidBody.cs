using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicRigidBody : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }
}
