using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class timer : MonoBehaviour
{
    bool timerOn = true;
    float currentTime;
    public float startTime;
    public TMP_Text timerText;
    public Gameover gameoverScreen;
    private void Start()
    {
        currentTime = startTime * 60;
    }

    private void Update()
    {
        if (timerOn)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <=0)
            {
                timerOn = false;
                GameOver();
            }
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        timerText.text = time.ToString("mm':'ss");
    }

   
    
    public void GameOver()
    {
        gameoverScreen.Setup();
    }
    
    
    public void Restart()
    {
        print("restarted");
        gameoverScreen.Restart();
    }
}
