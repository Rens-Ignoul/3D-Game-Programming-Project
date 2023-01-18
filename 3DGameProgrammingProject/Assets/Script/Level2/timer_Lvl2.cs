using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class timer_Lvl2 : MonoBehaviour
{
    public bool timerOn = true;
   public float currentTime;
    public float startTime;
    public TMP_Text timerText;
    public Gameover_Lvl2 gameoverScreen;
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
        System.Threading.Thread.Sleep(10000);
        SceneManager.LoadScene(0);
    }
    
    
   
}
