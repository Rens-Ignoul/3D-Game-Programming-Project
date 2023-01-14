using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI showText;
    public static int amount;

    private void Start()
    {
        UpdateScore();
    }
    public void Collision()
    {
        amount += 50;
        UpdateScore();
    }
    private void UpdateScore()
    {
        showText.text = "Score: " + amount.ToString();
    }
}
