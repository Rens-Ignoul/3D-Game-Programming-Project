using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashSpawner_Lvl2 : MonoBehaviour
{
    [SerializeField]
    private int trashCount = 50;
    public GameObject[] trashArr ;
    private float maxAngle = 180f;
    [Range(115, 130)]
    public int height = 120;

    void Start()
    {
        for (int i = 0; i < trashCount; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(430, 1300), height, Random.Range(-1100, 3700)); // Random position in the water
            GameObject trash = Instantiate(trashArr[Random.Range(0, trashArr.Length)], spawnPosition, GenerateRandomRotation()); // Spawn a random piece of trash
            trash.tag = "trash";// Set the tag of the trash to "trash"
        }
    }

    Quaternion GenerateRandomRotation() // Generate a random rotation
    {
        Quaternion randomRotation = Quaternion.Euler(
            Random.Range(-15, 15),
            Random.Range(-maxAngle, maxAngle),
            Random.Range(-maxAngle, maxAngle)
            );
        return randomRotation;
    }



}
