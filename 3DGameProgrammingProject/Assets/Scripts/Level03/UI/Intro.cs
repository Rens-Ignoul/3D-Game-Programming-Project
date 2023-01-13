using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{

    public GameObject IntroMenu;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        
        Time.timeScale = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Begin()
    {
        Cursor.lockState = CursorLockMode.Locked;
        IntroMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}
