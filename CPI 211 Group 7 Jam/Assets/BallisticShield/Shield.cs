using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private bool toggle = false;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (toggle == true)
            {
                anim.Play("ShieldDown");
                toggle = false;
            }
            else
            {
                anim.Play("ShieldUp");
                toggle = true;
            }
        }
    }
}
