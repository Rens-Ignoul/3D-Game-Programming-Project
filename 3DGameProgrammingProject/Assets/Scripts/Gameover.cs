using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
   public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {
        print("restarted x2");
        SceneManager.LoadScene("Level 2");
    }
}
