using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera playerCam;
    public float TargetDistance;
    public int bulletNumber = 5;
    public float reloadTime = 5f;
    private float reloadTimeReset;
    private int bulletReload;
    public AudioSource gunShot;
    public AudioClip gunShotClip;
    public AudioSource reloadSound;
    public AudioClip reloadSoundClip;
    private bool playedReload = false;
    public float shootTime = 10f;
    private float shootTimeReset;


    // Start is called before the first frame update
    void Start()
    {
        bulletReload = bulletNumber;
        reloadTimeReset = reloadTime;
        gunShot.clip = gunShotClip;
        shootTimeReset = shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1.0f)
        {
            reloadSound.UnPause();
            if (bulletNumber > 0)
            {
                Clicked();
                playedReload = false;
                reloadSound.Stop();
            }
            else
            {
                bulletNumber = -1;
                reloadTime -= Time.deltaTime;
                if (!playedReload)
                {
                    reloadSound.Play();
                    playedReload = true;
                }
                if (reloadTime <= Mathf.Epsilon)
                {
                    bulletNumber = bulletReload;
                    reloadTime = reloadTimeReset;
                }
            }
            if (bulletNumber < bulletReload && Input.GetKeyDown("r"))
            {
                bulletNumber = -1;
            }
        }
        else
        {
            reloadSound.Pause();
        }
    }

    public void Clicked()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = playerCam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));

            Debug.Log("Clicked");
            if (Physics.Raycast(ray, out hit))
            {

                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                print("I'm looking at " + hit.transform.name);
                TargetDistance = hit.distance;

                //ADDED
                if(hit.transform.tag == "Enemy")
                {
                    hit.transform.GetComponent<HealthSystem>().Damage(10f);
                }
            }
            else
            {
                print("I'm looking at nothing!");
            }
            bulletNumber--;
            gunShot.Play();
        }

    }
}
