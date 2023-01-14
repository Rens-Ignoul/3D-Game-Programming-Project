using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public GameObject projectilePrefab; // The prefab for the projectile
    public float projectileForce = 10f; // The force with which the projectile will be shot
    public Transform cameraTransform; // The transform component of the camera
    
    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the fire button
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate a new projectile at the position and rotation of the camera
            // Instantiate a new projectile at the position and rotation of the camera
            GameObject projectile = Instantiate(projectilePrefab, cameraTransform.position + cameraTransform.forward.normalized, Quaternion.Euler(cameraTransform.rotation.eulerAngles.x, cameraTransform.rotation.eulerAngles.y + 180, -cameraTransform.rotation.eulerAngles.z));


            // Add force to the projectile in the direction the camera is pointing
            projectile.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * projectileForce, ForceMode.Impulse);
        }
    }
}
