using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    [HideInInspector]
    public float remainingSeconds = 300;
    public TextMeshProUGUI countdownText;

    void Update()
    {

        if (remainingSeconds > 0)
        {
            remainingSeconds -= Time.deltaTime;
            timeUI(remainingSeconds);
        }
        else
        { remainingSeconds = 0; }

    }
    void timeUI(float timeToShow)
    {
        timeToShow += 1;
        float minutes = Mathf.FloorToInt(timeToShow / 60);
        float seconds = Mathf.FloorToInt(timeToShow % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}


