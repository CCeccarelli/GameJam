using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public BulletManager bm;
    public BulletController bc;
    public GameObject spawn;
    public int score = 0;
    public Text scoreText;
    public RawImage imgBlue;
    public RawImage imgGreen;
    public RawImage imgYellow;

    void Start()
    {
        bc.GetComponent<Rigidbody>();
        imgGreen.enabled = false;
        imgYellow.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            fire();
            
        }

        scoreText.text = "Score: " + score;
    }

    void fire()
    {
        GameObject temp = bm.getBullet();
        temp.SetActive(true);
        temp.transform.position = spawn.transform.position;
        //temp.GetComponent<BulletController>().testParameters(new Vector3(0,1,2));
        var instatiatedBC = temp.GetComponent<BulletController>();
        instatiatedBC.testParameters(new Vector3(0,0,2));
        Debug.Log(bm.index);

        if(bm.index == 0)
        {
            imgBlue.enabled = false;
            imgGreen.enabled = true;
            imgYellow.enabled = false;
        }
        else if (bm.index == 1)
        {
            imgBlue.enabled = false;
            imgGreen.enabled = false;
            imgYellow.enabled = true;
        }
        else if (bm.index == 2)
        {
            imgBlue.enabled = true;
            imgGreen.enabled = false;
            imgYellow.enabled = false;
        }
    }
}