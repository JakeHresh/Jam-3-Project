using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sceneNav : MonoBehaviour
{
    public bool win = false;
    public bool toMove = true;
    public GameObject[] waypoints;
    public GameObject[] enemies;
    public GameObject text;
    public GameObject canvas;
    int currentWaypoint = 0;
    int count = 0;

    public NavMeshAgent agent;

    private void Start()
    {

    }

    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (currentWaypoint < waypoints.Length && toMove == true)
        {
            //moves to each waypoint
            agent.SetDestination(waypoints[currentWaypoint].transform.position);

            if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 2.0)
            {
                currentWaypoint++;
                toMove = false;
            }
        }

        if(enemies.Length == 0 && toMove == false && count == 0)
        {
            Instantiate(text, canvas.transform);
            count = 1;
        }

        if (Input.GetKeyDown(KeyCode.Space) && enemies.Length == 0)
        {
            Destroy(text);
            count = 0;
            toMove = true;

            if (currentWaypoint == waypoints.Length)
            {
                win = true;
            }

        }
    }

    public void MoveNext()
    {
        toMove = true;
    }
}
