using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour
{
    public int maxSpeed;
    private Vector3 startPosition;

    void Start()
    {
        maxSpeed = 1;
        startPosition = transform.position;
    }
    void Update()
    {
        transform.position = new Vector3(startPosition.x, startPosition.y + Mathf.Sin((Time.time) * maxSpeed), startPosition.z);
    }

}
