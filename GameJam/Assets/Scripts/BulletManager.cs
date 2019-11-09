using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public GameObject gift;
    GameObject temp;
    public List<GameObject> people;
    public int sizeList;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sizeList; i++)
        {
            people.Add(Instantiate(gift, new Vector3(0,0,0), Quaternion.identity));
            people[i].GetComponent<BulletController>().bm = this;
            people[i].SetActive(false);
            people[i].transform.name = "Bullet_" + i;
        }
        sizeList = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public GameObject getBullet()
    {
        int temp2 = sizeList;
        if (sizeList > people.Count - 1)
        {
            sizeList = 0;
            temp2 = sizeList;
        }
        else
        {
            sizeList++;
        }

        return people[temp2];
            
        
    }

    public void resetBullet(GameObject b)
    {
        b.SetActive(false);
        b.transform.position = new Vector3(0, 0, 0);
    }
}
