using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Animator anim;
    private bool toggle = false;
    private float counter = 10f;
    public Shooting shotCount;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shotCount.bulletNumber > 0)
        {
            if (Input.GetMouseButtonDown(0)) //&& !toggle)
            {
                anim.Play("Fire");
                toggle = true;
            }
            if (toggle)
            {
                counter--;
            }
            if (counter <= Mathf.Epsilon && toggle)
            {
                anim.Play("idle");
                counter = 10f;
                toggle = false;
            }
        }
    }
}


