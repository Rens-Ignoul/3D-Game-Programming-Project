using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeleter : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Destroy the object that this script is attached to
        Destroy(gameObject);
    }
}
