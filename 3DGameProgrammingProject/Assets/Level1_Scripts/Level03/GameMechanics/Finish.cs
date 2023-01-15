using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{

    public GameObject CanvasObject;
    public TextMeshProUGUI ScoreText;
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        CanvasObject.SetActive(true);
        ScoreText.text = $"You got {ScoreManager.amount} points!";
    }
    public void ContinueButton()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
    }
}
