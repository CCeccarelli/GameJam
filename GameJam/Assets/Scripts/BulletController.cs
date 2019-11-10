using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletController : MonoBehaviour
{
    public PlayerController pc;
    public BulletManager bm;
    Rigidbody rb;
    public AudioSource hitSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 r = mousePos - transform.position;
        rb.AddForce(r * 2, ForceMode.Impulse);
        hitSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        checkBound();
        //rb.rotation = Quaternion.Euler
        //    (rb.rotation.eulerAngles + new Vector3(0f, 1 * Input.GetAxis("Mouse X"), 0f));
        //testParameters();
        hitSound.Play();

    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.GetComponent<Renderer>().material.color == this.gameObject.GetComponent<Renderer>().material.color)
        {
            //Debug.Log("hit");
            //bm.giftList.RemoveAt(bm.sizeList);
            bm.resetBullet(this.gameObject);
            pc.score++;

        }
    }

    void checkBound()
    {
        if(transform.position.y < -5)
        {
            //Destroy(this.gameObject);
            bm.resetBullet(this.gameObject);
            rb.velocity = new Vector3(0, 0, 0);
        }
    }

    public void testParameters(Vector3 vel)
    {
        rb = GetComponent<Rigidbody>();

        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 r = mousePos - transform.position;
        rb.AddForce(r * 2, ForceMode.Impulse);

        //Debug.Log(this.name + " : " + vel);

        //rb.velocity = vel;

    }

}
