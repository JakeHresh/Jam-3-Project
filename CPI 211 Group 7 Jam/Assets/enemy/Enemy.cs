using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    public float timeLeft = 1f;
    private float timeReset;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player");
        timeReset = timeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(Player.transform.position.x, this.transform.position.y, Player.transform.position.z);
        this.transform.LookAt(targetPosition);
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            anim.SetBool("Shoot", true);
        }
        else
        {
            anim.SetBool("Shoot", false);
        }
        if(timeLeft <= -7f)
        {
            timeLeft = timeReset;
        }

    }


}   
