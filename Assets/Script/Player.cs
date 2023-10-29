using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<GameObject> desObjects = new List<GameObject>();
    public GameObject cube;
    public List<GameObject> patrolLocations;
    public List<Vector3> spawnLocations;
    public int i = 0, checkPoint = 0, currentPatrolLocation = 0;
    public float patrolSpeed = 0f, rotateSpeed = 0f, waitTime = 0f, currentTime = 0f;
    public bool timeReached, attacked, lookingAtObject;

    private void Start()
    {
        for(int i = 0; i < spawnLocations.Count; i++)
        {
            GameObject go = Instantiate(cube, spawnLocations[i], Quaternion.identity);
            desObjects.Add(go);
        }

        StartCoroutine(PatrolAndAttack());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(checkPoint == 0)
            {
                checkPoint = 1;
            }
        }
    }

    IEnumerator PatrolAndAttack()
    {
        waitTime = Random.Range(2, 5);

        

        while (checkPoint == 0)
        {
            if (!timeReached)
            {
                currentTime += Time.deltaTime;
            }

            if (currentTime > waitTime)
            {
                timeReached = true;
            }

            if (!timeReached && !lookingAtObject)
            {
                Patrol();
            }
            else if(timeReached && !lookingAtObject)
            {
                Rotate();
            }
            else if(timeReached && lookingAtObject)
            {
                //Attack();

                yield return new WaitForSeconds(1f);
                yield return new WaitUntil(() => attacked == true);

                i++;
                if(i >= desObjects.Count)
                {
                    i = 0;
                }

                currentTime = 0;
                attacked = false;
                lookingAtObject = false;
                timeReached = false;
            }

            yield return null;
        }

        yield return new WaitUntil(() => checkPoint == 1);
    }

    public void Patrol()
    {
        Vector3 destination = patrolLocations[currentPatrolLocation].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, patrolSpeed * Time.deltaTime);

        Quaternion lookRotation = Quaternion.LookRotation(destination - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, rotateSpeed * Time.deltaTime);

        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if(distance <= 0.05)
        {
            currentPatrolLocation++;
            if(currentPatrolLocation >= patrolLocations.Count)
            {
                currentPatrolLocation = 0;
            }
        }
    }

    public void Rotate()
    {
        Quaternion lookRotation = Quaternion.LookRotation(desObjects[i].transform.position - transform.position);

        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, rotateSpeed * Time.deltaTime);

        Vector3 dirToTarget = Vector3.Normalize(desObjects[i].transform.position - transform.position);
        float viewDistance = Vector3.Dot(transform.forward, dirToTarget);
        Debug.Log(viewDistance);
        if (viewDistance >= 0.999)
        {
            lookingAtObject = true;
            attacked = true;
        }
    }
}
