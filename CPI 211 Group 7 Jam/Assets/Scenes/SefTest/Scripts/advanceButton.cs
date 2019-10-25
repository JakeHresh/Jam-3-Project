using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advanceButton : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject[] obj;

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < obj.Length; i++)
        {
            Instantiate(enemy, obj[i].transform.position, Quaternion.LookRotation(player.transform.position - obj[i].transform.position, Vector3.up));
        }

        Debug.Log("Entered!");
    }
}
