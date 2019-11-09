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
        checkBound();
        rb.rotation = Quaternion.Euler
            (rb.rotation.eulerAngles + new Vector3(0f, 1 * Input.GetAxis("Mouse X"), 0f));
        //testParameters();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            Debug.Log("hit");
        }
    }

    void checkBound()
    {
        if(transform.position.y < -5)
        {
            bm.resetBullet(this.gameObject);
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    public void testParameters(Vector3 vel)
    {
        
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 r = mousePos - transform.position;
        rb.AddForce(r * 2, ForceMode.Impulse);

        //Debug.Log(this.name + " : " + vel);

        //rb.velocity = vel;

    }

}
