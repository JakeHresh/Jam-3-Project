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



    public float shotDelay;
    private float shotCounter;

    // Use this for initialization
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.rotation * Vector3.left, player.transform.rotation * Vector3.up);
        var rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10);
        float probability = Time.deltaTime * shotsPerSeconds;
        if (Random.value < probability)
        {
            Fire();
        }
    }
    void Fire()
    {

        GameObject instBullet =  Instantiate(bullet, bulletPoint.position, bulletPoint.rotation) as GameObject;
        instBullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
       


    }
}