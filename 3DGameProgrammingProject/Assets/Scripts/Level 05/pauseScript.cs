using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseScript : MonoBehaviour
{
    public Canvas canvasObject;
    public Canvas resumeCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Application.Quit();
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            canvasObject.enabled = true;
            resumeCanvas.enabled = true;
        }

    }

    public void ReturnButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1.0f;
        canvasObject.enabled = false;
        resumeCanvas.enabled = false;
    }

    public void QuitButton()
    {
        Application.Quit(); //werkt alleen met build and run
    }
}