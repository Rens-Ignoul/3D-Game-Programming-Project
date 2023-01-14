using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public TMP_Text pointsText;
    private int totalPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = getPoints().ToString();
    }

    public void addPoint()
    {
        totalPoints += 1;
        pointsText.color = Color.green;
        Invoke("ResetColor", 1f);
    }

    public int getPoints()
    {
        return totalPoints;
    }
    public void resetPoints()
    {
        totalPoints = 0;
    }
    private void ResetColor()
    {
        pointsText.color = Color.white;
    }
}
