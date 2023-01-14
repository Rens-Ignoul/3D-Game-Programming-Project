using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitVelocity : MonoBehaviour
{
    public float maxVelocity = 10f;

    Rigidbody rb;

    void Start()
    {
        // Get the rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Clamp the velocity to the maximum value
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
    }
}
