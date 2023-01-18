using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager4 : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public TMP_Text eindScore;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
        eindScore.text = "Uw behaalde score is: " + score;
    }
}
