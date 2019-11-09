using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject spawnLocation;
    public GameObject gift;
    GameObject temp;
    public List<GameObject> people;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            people.Add(Instantiate(gift, spawnLocation.transform.position, Quaternion.identity));
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            fire();
            Debug.Log("test");
        }
    }

    void fire()
    {
        //temp.transform.Translate(1, 0, 0);

    }
}
