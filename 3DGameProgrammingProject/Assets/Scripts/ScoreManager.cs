using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI showText;
    public static int amount;
    void Start()
    {
        showText.text = "Score: " + amount.ToString();
    }
    public void Collision()
    {
        amount += 50;
        showText.text = "Score: " + amount.ToString();
    }
}
