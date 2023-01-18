using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause4 : MonoBehaviour
{
    public GameObject canvasObject;
    public Button unPause;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //Application.Quit();
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            canvasObject.SetActive(true);
            
        }
        unPause.onClick.AddListener(ReturnButton);

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