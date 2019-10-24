using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerNav : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWaypoint = 0;

    public NavMeshAgent agent;

    private void Start()
    {

    }

    private void Update()
    {

        if (waypoints.Length > 0)
        {
            //moves to each waypoint
            agent.SetDestination(waypoints[currentWaypoint].transform.position);

            if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 3.5)
            {
                currentWaypoint++;
                if (currentWaypoint >= waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
            
        }
    }
}