using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Camera playerCam;
    public float TargetDistance;
    public int bulletNumber = 5;
    public float reloadTime = 3f;
    private float reloadTimeReset;
    private int bulletReload;


    // Start is called before the first frame update
    void Start()
    {
        bulletReload = bulletNumber;
        reloadTimeReset = reloadTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletNumber > 0)
        {
            Clicked();
        }
        else
        {
            reloadTime -= Time.deltaTime;
            if(reloadTime <= Mathf.Epsilon)
            {
                bulletNumber = bulletReload;
                reloadTime = reloadTimeReset;
            }
        }
        if (bulletNumber < bulletReload && Input.GetKeyDown("r"))
        {
            bulletNumber = 0;
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
            }
            else
            {
                print("I'm looking at nothing!");
            }
            bulletNumber--;
        }

    }
}
