using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sceneNav : MonoBehaviour
{
    public bool toMove = true;
    public GameObject[] waypoints;
    public GameObject[] enemies;
    int currentWaypoint = 0;

    public NavMeshAgent agent;

    private void Start()
    {

    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (waypoints.Length > 0 && toMove == true)
        {
            //moves to each waypoint
            agent.SetDestination(waypoints[currentWaypoint].transform.position);

            if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 3.5)
            {
                currentWaypoint++;
                toMove = false;
            }

            //Destroys previous waypoint
            Destroy(waypoints[currentWaypoint - 1]);
        }

        if (Input.GetKeyDown(KeyCode.Space) || enemies.Length == 0)
        {
            toMove = true;
        }
    }

    public void MoveNext()
    {
        toMove = true;
    }
}
