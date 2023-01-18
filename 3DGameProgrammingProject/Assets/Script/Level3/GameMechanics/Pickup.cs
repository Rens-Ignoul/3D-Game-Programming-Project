using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            source.PlayOneShot(clip);
            ScoreManager.amount += 50;
            Destroy(gameObject);
        }
    }
}
