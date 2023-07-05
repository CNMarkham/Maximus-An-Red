using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public CodeyMove Player;
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public SelectRandomPoweroop Poweroop;
    // Start is called before the first frame update
    void Start()
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
            startCountdown.text = ToString();
            totalLapTime -= Time.deltaTime;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            
        }
        if (totalCountdownTime < 0)
        {
            print("Time is up, you awful little piece of paper!");
        }
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}
