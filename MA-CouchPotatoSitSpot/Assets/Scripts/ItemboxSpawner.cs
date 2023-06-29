using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemboxSpawner : MonoBehaviour
{
    public GameObject ItemBox;

    public int numberOfBoxes;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfBoxes; i++)
        {
            Vector3 Spawnlocation2 = new Vector3(transform.position.x + (i * 5), transform.position.y, transform.position.z);
            GameObject itemBoxClone = Instantiate(ItemBox, Spawnlocation2, Quaternion.identity);
        }
    }

    // Update is called once per frames
    void Update()
    {
        
    }
}
