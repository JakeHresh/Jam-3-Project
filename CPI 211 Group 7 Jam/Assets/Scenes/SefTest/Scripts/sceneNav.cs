using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sceneNav : MonoBehaviour
{
    public bool win = false;
    public bool toMove = true;
    public GameObject[] waypoints, enemies;
    public GameObject text;
    public GameObject canvas;
    public AudioClip firstAudioClip, secondAudioClip;
    int currentWaypoint = 0;
    int count = 0;

    public NavMeshAgent agent;

    private void Start()
    {
        text.SetActive(false);
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

        if (enemies.Length == 0 && toMove == false && count == 0)
        {
            if(currentWaypoint < waypoints.Length)
            {
                text.SetActive(true);
                count = 1;
                transform.GetComponent<AudioSource>().PlayOneShot(firstAudioClip);
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space) && enemies.Length == 0)
        {
            transform.GetComponent<AudioSource>().PlayOneShot(secondAudioClip);
            text.SetActive(false);
            count = 0;
            toMove = true;
        }

        if (currentWaypoint == waypoints.Length && enemies.Length == 0)
        {
            win = true;
        }
    }
}
