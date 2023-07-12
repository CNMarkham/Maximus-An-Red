using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    Rigidbody thing;
    // Start is called before the first frame update
    void Start()
    {
        thing = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        thing.AddForce(transform.forward * Time.deltaTime * 5);
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
