using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer4 : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TMP_Text timeText;
    public GameObject canvasObject;
    public GameObject canvasObject2;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;

     

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
                Time.timeScale = 0f;
                canvasObject.SetActive(true);
                canvasObject2.SetActive(false);
                Cursor.lockState = CursorLockMode.None;

            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.color = Color.green;
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (seconds < 31)
        {
            timeText.color = Color.red;
            if (seconds % 2 == 0)
            {
                timeText.color = Color.red;
            }
            else
            {
                timeText.color = Color.white;
            }
        }

    }
}