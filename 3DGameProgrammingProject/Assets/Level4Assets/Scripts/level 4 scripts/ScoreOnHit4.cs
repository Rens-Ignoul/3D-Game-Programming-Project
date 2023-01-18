using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnHit4 : MonoBehaviour
{
    public int pointsToAdd;

    public void AddPoints(int points)
    {
        var scoreManager = FindObjectOfType<ScoreManager4>();
        scoreManager.score += points;
    }

    private void OnCollisionEnter(Collision collision)
    {
        AddPoints(pointsToAdd);
    }
}
