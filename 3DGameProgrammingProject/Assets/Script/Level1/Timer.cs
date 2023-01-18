using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{


    public static float remainingSeconds = 300;
    public TextMeshProUGUI countdownText;
    L1_TimerNextLevel timerNextLevel;

    private void FixedUpdate()
    {
        if (remainingSeconds <= 0)
        {
            remainingSeconds = 0;
            timerNextLevel = GetComponent<L1_TimerNextLevel>();
            timerNextLevel.TimerRanOut();
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
        if (remainingSeconds <= 0) countdownText.text = "00:00";
        else
        {
            countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        
        countdownText.color = Color.green;
        if (minutes < 1)
        {
            countdownText.color = Color.red;
            if (seconds % 2 == 0)
            {
                countdownText.color = Color.red;
            }
            else
            {
                countdownText.color = Color.white;
            }
        }
        else
        {
            countdownText.color = Color.green;
        }
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


