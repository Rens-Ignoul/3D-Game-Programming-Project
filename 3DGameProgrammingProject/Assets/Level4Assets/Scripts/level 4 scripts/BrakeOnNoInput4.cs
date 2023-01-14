using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeOnNoInput4 : MonoBehaviour
{
    public float brakingForce = 10f;

    Rigidbody rb;

    void Start()
    {
        // Get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Check the input from the horizontal and vertical axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // If there is no input, apply a braking force to the rigidbody
        if (horizontalInput == 0 && verticalInput == 0)
        {
            rb.AddForce(-rb.velocity * brakingForce, ForceMode.Acceleration);
        }
    }
}
