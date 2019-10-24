using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advanceButton : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered!");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited!");
    }
}
