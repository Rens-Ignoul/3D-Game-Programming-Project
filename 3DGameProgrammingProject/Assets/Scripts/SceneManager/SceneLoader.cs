using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public int LevelNumber;
    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadLevelFour()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadLevelFive()
    {
        SceneManager.LoadScene(5);
    }
}
