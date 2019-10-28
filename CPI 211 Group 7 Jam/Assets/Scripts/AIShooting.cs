using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletPoint;
    public float shotsPerSeconds;
    public Transform player;
    public float bulletSpeed = 100;
    public Enemy enemyBehavior;
    private bool canShoot = true;

    private AudioSource gunSource;

    public float shotDelay = 100;
    private float shotCounter;

    // Use this for initialization
    void Start()
    {
        //bulletPoint = GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyBehavior = GetComponent<Enemy>();
        shotCounter = shotDelay;
        gunSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.rotation * Vector3.left, player.transform.rotation * Vector3.up);
        if(Time.timeScale == 1)
        {
            var rotation = Quaternion.LookRotation(player.position - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
            float probability = Time.deltaTime * shotsPerSeconds;
            if (enemyBehavior.anim.GetBool("IsShooting"))
            {
                shotDelay--;
                if (shotDelay % 50 == 0)
                {
                    Fire();
                }
            }
            if (!enemyBehavior.anim.GetBool("IsShooting"))
            {
                shotDelay = shotCounter;
            }
        }
    }
    void Fire()
    {

        GameObject instBullet =  Instantiate(bullet, bulletPoint.position, bulletPoint.rotation) as GameObject;
        instBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        gunSource.Play();


    }
}