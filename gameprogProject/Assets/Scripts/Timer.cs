using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{


    public static float remainingSeconds = 300;
    public TextMeshProUGUI countdownText;

    private void FixedUpdate()
    {
        if (remainingSeconds <= 0)
        {
            remainingSeconds = 0;
        }
        else
        {
            remainingSeconds -= 1* Time.deltaTime;
            TimeUI(remainingSeconds);
        }
    }

    private void TimeUI(float timeToShow)
    {
        float minutes = Mathf.FloorToInt(timeToShow / 60);
        float seconds = Mathf.FloorToInt(timeToShow % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void IncreaseTime()
    {
        remainingSeconds += 60;
    }

    public void DecreaseTime()
    {
        remainingSeconds -= 60;
    }
   
}


