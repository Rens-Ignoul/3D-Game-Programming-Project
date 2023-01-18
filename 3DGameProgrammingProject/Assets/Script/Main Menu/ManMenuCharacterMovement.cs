using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManMenuCharacterMovement : MonoBehaviour
{
    public float speed = 0.75f; // Speed at which the object should move

    void Update()
    {
        transform.position -= new Vector3(0, 0, speed * Time.deltaTime); // Lower the Z position by the speed

        if (transform.position.z <= 0) // Check if the Z position is less than or equal to 0
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 5); // Reset the Z position to 0
        }
    }
}
