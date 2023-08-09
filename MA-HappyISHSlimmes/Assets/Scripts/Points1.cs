using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Points1 : MonoBehaviour
{
    public Text Text;
    public Points points;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
            points.PointCount += 4;
            Text.text = ("Points: " + points.PointCount);

        }
    }
}
