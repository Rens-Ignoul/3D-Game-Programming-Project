using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L1_Pause : MonoBehaviour
{
    public GameObject canvasObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            canvasObject.SetActive(true);
        }

    }

    public void ReturnButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1.0f;
        canvasObject.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit(); //werkt alleen met build and run
    }
}
