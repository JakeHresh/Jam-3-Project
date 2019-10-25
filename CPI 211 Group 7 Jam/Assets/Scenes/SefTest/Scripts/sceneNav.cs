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

            if (Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position) < 2.0)
            {
                currentWaypoint++;
                toMove = false;
            }
<<<<<<< HEAD

=======
            
>>>>>>> f6126b19cd3991d864519d00dc3d3add186ebb78
        }

        if (Input.GetKeyDown(KeyCode.Space)) //|| enemies.Length == 0)
        {
            toMove = true;
<<<<<<< HEAD

            if (currentWaypoint == waypoints.Length - 1)
            {
                win = true;
            }
=======
            
>>>>>>> f6126b19cd3991d864519d00dc3d3add186ebb78
        }
    }

    public void MoveNext()
    {
        toMove = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Waypoint")
        {
            //Destroys previous waypoint
            Destroy(waypoints[currentWaypoint - 1]);
        }
    }
}
