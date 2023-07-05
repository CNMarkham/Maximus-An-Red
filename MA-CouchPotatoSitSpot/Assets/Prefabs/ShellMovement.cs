using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
    }
}
