using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("Go Touch Air!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Step 58
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
