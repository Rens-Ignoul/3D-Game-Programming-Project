using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashSpawner : MonoBehaviour
{
    public GameObject[] trashArr;
    private float maxAngle=180f;

    void Start()
    {
        Quaternion randomRotation = Quaternion.Euler(
            Random.Range(-maxAngle, maxAngle),
            Random.Range(-maxAngle, maxAngle),
            Random.Range(-maxAngle, maxAngle)
        );

        //do this 25 times
        for (int i = 0; i < 45; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(430, 1300), 110, Random.Range(-1100, 3700)); // Random position in the water
            GameObject trash = Instantiate(trashArr[Random.Range(0, trashArr.Length)], spawnPosition, randomRotation) ; // Spawn a random piece of trash
            trash.tag = "trash";
        }


    }



}
