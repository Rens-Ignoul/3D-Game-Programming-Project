using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    // The prefab that will be spawned
    public GameObject prefab;

    // The minimum and maximum values for the x and y coordinates
    public Vector2 xRange = new Vector2(-10, 10);
    public Vector2 yRange = new Vector2(-10, 10);
    public Vector2 zRange = new Vector2(-10,10);

    // The minimum and maximum spawn rates (in seconds)
    public Vector2 rateRange = new Vector2(1, 5);

    // The size of the box used to check for collisions
    public Vector3 boxSize = new Vector3(1, 1, 1);

    void Start()
    {
        // Start spawning objects at a random rate
        InvokeRepeating("SpawnObject", 0, Random.Range(rateRange.x, rateRange.y));
    }

    void SpawnObject()
    {
        // Generate a random position within the specified ranges
        float x = Random.Range(xRange.x, xRange.y);
        float y = Random.Range(yRange.x, yRange.y);
        float z = Random.Range(zRange.x, zRange.y);
        Vector3 position = new Vector3(x, y, z);

        // Check if the position is inside another object
        Collider[] colliders = Physics.OverlapBox(position, boxSize);
        if (colliders.Length == 0)
        {
            // Spawn the prefab at the random position
            Instantiate(prefab, position, Quaternion.identity);
        }
    }
}
