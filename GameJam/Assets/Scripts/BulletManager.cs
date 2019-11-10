using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public GameObject gift;
    GameObject temp;
    public List<GameObject> giftList;
    public List<Material> matList;
    public int sizeList;
    public int sizeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sizeMaterial; i++)
        {
            matList.Add(Resources.Load("Material/blue", typeof(Material)) as Material);
            matList.Add(Resources.Load("Material/darkGreen", typeof(Material)) as Material);
            matList.Add(Resources.Load("Material/yellow", typeof(Material)) as Material);
        }

        for (int i = 0; i < sizeList; i++)
        {
            
            giftList.Add(Instantiate(gift, new Vector3(0,0,0), Quaternion.identity));
            giftList[i].GetComponent<Renderer>().material = matList[i];
            giftList[i].GetComponent<BulletController>().bm = this;
            giftList[i].SetActive(false);
            giftList[i].transform.name = "Bullet_" + i;
            
        }
        
        sizeList = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /// <summary>
    /// Returns a bullet object from the object pool.
    /// </summary>
    /// <returns>A bullet GameObject</returns>
    public GameObject getBullet()
    {
        if(sizeList > 2)
        {
            sizeList = 0;
            return giftList[sizeList++];
        }
        else
        {
            return giftList[sizeList++];
        }      
    }

    public void resetBullet(GameObject b)
    {
        b.SetActive(false);
        b.transform.position = new Vector3(0, 0, 0);
    }
}
