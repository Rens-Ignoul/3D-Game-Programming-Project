using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnHit : MonoBehaviour
{
    public int pointsToAdd;

    public void AddPoints(int points)
    {
        var scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.score += points;
    }

    private void OnCollisionEnter(Collision collision)
    {
        AddPoints(pointsToAdd);
    }
}
