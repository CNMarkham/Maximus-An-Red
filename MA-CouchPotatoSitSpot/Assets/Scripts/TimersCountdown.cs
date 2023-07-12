using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public CodeyMove Player;
    public CheckpointCounter checkpointTracker;
    public Text winText;
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public SelectRandomPoweroop Poweroop;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Thing", 4);
        
    }

    void Thing()
    {
        Player.Speed = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if(totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            Player.Speed = 0;
        } 
        if(totalCountdownTime <= 0)
        {
            if (checkpointTracker.triggeredCheckpoints != checkpointTracker.numberOfCheckpoints)
            {
                startCountdown.text = ToString();
                totalLapTime -= Time.deltaTime;
                lapTime.text = Mathf.Round(totalLapTime).ToString();
            }
            //winText.text = "You Got Worse";


        }
        if (totalCountdownTime < 0)
        {
            print("Time is up, you awful little piece of paper!");
        }
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        //lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}
