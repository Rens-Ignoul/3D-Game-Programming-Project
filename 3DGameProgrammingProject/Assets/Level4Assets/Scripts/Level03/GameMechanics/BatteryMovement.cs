using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryMovement : MonoBehaviour
{
    public float rotationSpeed = 00f;
    public float movementSpeed = 1.0f;
    public float movementDistance = 0.25f;
    private float currentTime = 0.0f;
    private float initialY;
    private void Start()
    {
        initialY = gameObject.transform.position.y;
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);

        currentTime += Time.deltaTime;
        float yPos = Mathf.Sin(currentTime) * movementDistance;
        transform.position = new Vector3(transform.position.x, yPos+initialY/*+15.49f*/, transform.position.z);
    }
}
