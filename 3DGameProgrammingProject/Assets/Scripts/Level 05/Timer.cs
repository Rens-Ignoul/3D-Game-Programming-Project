using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public Canvas endCanvas;
    public Canvas resumeCanvas;


    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        endCanvas.enabled = false;
        resumeCanvas.enabled = false;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Time.timeScale = 0;
                resumeCanvas.enabled = false;
                endCanvas.enabled=true;
            }
        }
    }

    public void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.color = Color.white;
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (minutes == 0 && seconds < 31)
        {
            if (seconds % 2 == 0)
            {
                timeText.color = Color.red;
            }
            else if (seconds <= 1)
            {
                timeText.color = Color.gray;
            }
            else
            {
                timeText.color = Color.white;
            }
        }
    }

    public void resetTimer(int time)
    {
        this.timeRemaining = time;
        timerIsRunning = true;
    }

    public void addTime(int addedTime)
    {
        this.timeRemaining += addedTime;
        timeText.color = Color.green;
        timerIsRunning = true; 
        Invoke("ResetColor", 2f);
    }

    public float getTimeRemaining()
    {

        return this.timeRemaining;
       
    }

    public void subtractTime(int subtractedTime)
    {
        if (subtractedTime > timeRemaining)
        {
            timeRemaining = 0;
            timeText.color = Color.red;
        }
        else
        {
            timeRemaining -= subtractedTime;
            timeText.color = Color.red;
          //  Invoke("ResetColor", 2f);
        }
    }

    private void ResetColor()
    {
        timeText.color = Color.white;
    }
}