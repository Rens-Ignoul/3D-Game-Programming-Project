using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI showText;
    public static int amount;
    public void Start()
    {
        showText.text = "Score: " + amount.ToString();
        Debug.Log("Score is affected in ScoreManager!");
    }
    public void Collision()
    {
        amount += 50;
        showText.text = "Score: " + amount.ToString();
        Debug.Log("Score is affected in ScoreManager!");
    }
}
