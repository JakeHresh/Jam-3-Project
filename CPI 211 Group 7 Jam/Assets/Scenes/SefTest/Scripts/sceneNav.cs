using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sceneNav : MonoBehaviour
{
    public bool toMove = true;
    public GameObject[] waypoints;
    int currentWaypoint = 0;

    public NavMeshAgent agent;

    private void Start()
    {

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            toMove = true;
        }

        if (waypoints.Length > 0 && toMove == true)
        {
            //moves to each waypoint
            agent.SetDestination(waypoints[currentWaypoint].transform.position);

            if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 3.5)
            {
                currentWaypoint++;
                toMove = false;
                if (currentWaypoint >= waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }

        }
    }

    public void MoveNext()
    {
        toMove = true;
    }
}
