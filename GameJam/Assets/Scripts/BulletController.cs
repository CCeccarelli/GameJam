using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public BulletManager bm;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 10);
    }

    // Update is called once per frame
    void Update()
    {
             moveBullet();
        //testParameters();
    }

    void moveBullet()
    {
        //Debug.Log(this.name);
        //rb.AddForce();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            Debug.Log("hit");
        }
    }

    public void testParameters()
    {

        //Debug.Log(this.name + " : " + vel);
        rb.velocity = new Vector3(0,0,10);

    }

}
