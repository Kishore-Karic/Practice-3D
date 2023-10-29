using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player2 : MonoBehaviour
{
    public List<GameObject> targetLocations;
    public NavMeshAgent agent;
    public int i = 0;
    public bool down, up;

    private void Start()
    {
        agent.SetDestination(targetLocations[i].transform.position);
    }

    private void Update()
    {
        Vector3 playerPos = new Vector3(transform.position.x, 0f, transform.position.z);
        Vector3 targetPos = new Vector3(targetLocations[i].transform.position.x, 0f, targetLocations[i].transform.position.z);

        if(playerPos == targetPos)
        {
            i++;
            if(i >= targetLocations.Count)
            {
                i = 0;
            }

            agent.SetDestination(targetLocations[i].transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !down)
        {
            down = true;
            Debug.Log(down);
        }

        if (Input.GetKeyDown(KeyCode.RightAlt) && !up)
        {
            up = true;
            Debug.Log(up);
        }

        if (down)
        {
            Vector3 pos = transform.localPosition + Vector3.down * 0.1f;
            transform.localPosition = pos;
            agent.baseOffset -= 0.1f;
            Debug.Log("down");
            Debug.Log(transform.localPosition.y);
            if (transform.localPosition.y < 2f)
            {
                down = false;
                Debug.Log("if");
            }
        }

        if (up)
        {
            Vector3 pos = transform.localPosition + Vector3.up * 0.1f;
            transform.localPosition = pos;
            agent.baseOffset += 0.1f;
            Debug.Log("up");
            Debug.Log(transform.localPosition.y);
            if (transform.localPosition.y > 8f)
            {
                up = false;
                Debug.Log("if");
            }
        }
    }

    private void FixedUpdate()
    {
        
    }
}
