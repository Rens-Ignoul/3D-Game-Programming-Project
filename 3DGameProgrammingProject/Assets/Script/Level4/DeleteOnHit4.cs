using UnityEngine;

public class DeleteOnHit4 : MonoBehaviour
{
    public AudioSource soundToPlay;
    void OnCollisionEnter(Collision collision)
    {
        //Get the collider component of the object that hit this GameObject
        Collider collider = collision.gameObject.GetComponent<Collider>();
        if (collider.CompareTag("Delete"))
        {
            AudioSource.PlayClipAtPoint(soundToPlay.clip, transform.position);
            Destroy(gameObject);
        }
    }
}
