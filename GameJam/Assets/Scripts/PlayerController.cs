using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public BulletManager bm;
    public BulletController bc;
    public GameObject spawn;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            fire();
            
        }
    }

    void fire()
    {
        GameObject temp = bm.getBullet();
        temp.SetActive(true);
        temp.transform.position = spawn.transform.position;
        //temp.GetComponent<BulletController>().testParameters(new Vector3(0,1,2));
        var instatiatedBC = temp.GetComponent<BulletController>();
        instatiatedBC.testParameters();
    }
}