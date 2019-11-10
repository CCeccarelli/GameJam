using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class HoomanMovement : MonoBehaviour
{
    public GameObject mooMan;
    private bool cutLeft = false;
    private int startX;
    private float range;
    private float step = 0.05F;
    System.Random rnd = new System.Random();
    

    // Start is called before the first frame update
    void Start()
    {
        //Toheed is a bucktee
        startX = (int)mooMan.transform.position.x;
        cutLeft = (rnd.Next(0, 2)) == 1;
        range = (float)(rnd.NextDouble() + 0.4);
    }

    // Update is called once per frame
    void Update()
    {
        if (cutLeft)
        {
            if(mooMan.transform.position.x < (startX - range))
            {
                cutLeft = false;
            }
            mooMan.transform.position = new Vector3(mooMan.transform.position.x - step, mooMan.transform.position.y, mooMan.transform.position.z);
        }
        else
        {
            if (mooMan.transform.position.x > (startX + range))
            {
                cutLeft = true;
            }
            mooMan.transform.position = new Vector3(mooMan.transform.position.x + step, mooMan.transform.position.y, mooMan.transform.position.z);
        }
    }
}
