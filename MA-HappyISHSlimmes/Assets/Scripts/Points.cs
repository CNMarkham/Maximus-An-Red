using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Points : MonoBehaviour
{
    public Text Text;
    public int PointCount;
    // Start is called before the first frame update
    void Start()
    {
        PointCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Log");
            PointCount += 1;
            Text.text = ("Points: " + PointCount);

        }
    }
}
