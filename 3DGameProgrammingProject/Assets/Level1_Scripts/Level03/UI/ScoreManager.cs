using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI showText;
    public static int amount;
    public void Update()
    {
        showText.text = "Score: " + amount.ToString();
    }
    
}
