using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L1_TimerNextLevel : MonoBehaviour
{
    public GameObject canvasObject;

    public void TimerRanOut()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        canvasObject.SetActive(true);
    }
    public void QuitButton()
    {
        Application.Quit(); 
    }
    public void NextLevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
