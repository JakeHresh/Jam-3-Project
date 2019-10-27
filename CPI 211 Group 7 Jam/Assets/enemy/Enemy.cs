using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    private float timeLeft = 3;
    private float shootTime = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(Player.transform.position.x, this.transform.position.y, Player.transform.position.z);
        this.transform.LookAt(targetPosition);
        Debug.Log(anim.GetBool("shoot"));
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            shoot();
        }
        shootTime -= Time.deltaTime;
        if (shootTime < 0 && anim.GetBool("shoot") == true)
        {
            anim.SetBool("shoot", false);
            Debug.Log(anim.GetBool("shoot"));
        }
    }

    private void shoot()
    {
        anim.SetBool("shoot", true);
        Debug.Log(anim.GetBool("shoot"));
    }
}   
