using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class advanceButton : MonoBehaviour
{
    public GameObject trigger;

    private void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        Instantiate(trigger);
        Debug.Log("I'm Triggered!");
    }
}
