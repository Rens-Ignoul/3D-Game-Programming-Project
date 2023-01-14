using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnHit : MonoBehaviour
{
    public AudioSource soundToPlay;
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided with this object has a tag of "Delete"
        if (collision.collider.tag == "Delete")
        {
            AudioSource.PlayClipAtPoint(soundToPlay.clip, transform.position);
            Destroy(gameObject);
            
        }
    }
}
