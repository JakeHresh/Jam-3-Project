using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthSystem>().Damage(10);
        }
        Destroy(self);
    }
}
