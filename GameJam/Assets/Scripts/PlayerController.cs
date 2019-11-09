using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public BulletManager bm;
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
    }
}