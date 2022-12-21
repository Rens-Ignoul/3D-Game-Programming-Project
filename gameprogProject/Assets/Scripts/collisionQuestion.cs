using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionQuestion : MonoBehaviour
{

    public GameObject imageObject;
    public GameObject textObject;
    public GameObject firstButton;
    public GameObject secondButton;
    private Rigidbody rigid;
    

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            imageObject.SetActive(true);
            textObject.SetActive(true);
            firstButton.SetActive(true);
            secondButton.SetActive(true);

            rigid.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.Locked;
            imageObject.SetActive(false);
            textObject.SetActive(false);
            firstButton.SetActive(false);
            secondButton.SetActive(false);
            
        }
    }
  
}
