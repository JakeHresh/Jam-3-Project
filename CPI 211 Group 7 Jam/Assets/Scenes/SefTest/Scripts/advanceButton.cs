using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advanceButton : MonoBehaviour
{
    private GameObject player;
    public GameObject enemy;
    public GameObject[] spawnPoints;
    public bool spawned = false;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider other)
    {

        if(other == player.GetComponent<CapsuleCollider>())
        {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                Instantiate(enemy, spawnPoints[i].transform.position, Quaternion.LookRotation(player.transform.position - spawnPoints[i].transform.position, Vector3.up));
            }
            
        }
    }
}
