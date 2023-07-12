using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    public Text winText;
    void OnTriggerEnter(Collider other)
    {

        
        if (other.gameObject.tag == "Player")
        {
            if(checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("Go Touch Air!");
                winText.text = "You Got Worse";
                SceneManager.LoadScene(1);
                
            } else
            {
                print("Good job, just like me!");
                winText.text = "You Got Worse(x2)";
                SceneManager.LoadScene(2);
            }
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
