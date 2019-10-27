using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    private float timeLeft = Random.Range(3.0f, 7.0f);
    private float shootTime = 2.0f;
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

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            shoot();
        }
    }

    private void shoot()
    {
        anim.SetBool("Shoot", true);
        shootTime -= Time.deltaTime;
        if (shootTime < 0)
        {
            anim.SetBool("Shoot", false);
        }
    }
}   
