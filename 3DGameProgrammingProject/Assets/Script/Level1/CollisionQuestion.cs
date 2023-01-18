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
        rigid = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            if (imageObject != null) imageObject.SetActive(true);
            if (textObject != null) textObject.SetActive(true);
            if (firstButton != null) firstButton.SetActive(true);
            if (secondButton != null) secondButton.SetActive(true); //controleren op null zorgt ervoor dat public variables dat bij sommige objects niet gebruikt wordt, geen error geeft.

            if (rigid != null) rigid.constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.Locked;
            if (imageObject != null) imageObject.SetActive(false);
            if (textObject != null) textObject.SetActive(false);
            if (firstButton != null) firstButton.SetActive(false);
            if (secondButton != null) secondButton.SetActive(false);

        }
    }
  
}
