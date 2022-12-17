using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionQuestion : MonoBehaviour
{

    public GameObject imageObject;
    public GameObject textObject;
    public GameObject button1Object;
    public GameObject button2Object;
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
            button1Object.SetActive(true);
            button2Object.SetActive(true);

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
            button1Object.SetActive(false);
            button2Object.SetActive(false);
            
        }
    }
  
}
