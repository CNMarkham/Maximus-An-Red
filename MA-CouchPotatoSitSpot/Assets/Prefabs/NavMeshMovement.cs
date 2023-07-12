using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        GetComponent<NavMeshAgent>().destination = GameObject.FindGameObjectWithTag("Obstacle").transform.position;
    }
    
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

        }
    }
}
