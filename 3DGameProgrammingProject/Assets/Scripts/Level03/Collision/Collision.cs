using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject MainPlayerObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Obstacle")
        {
            MainPlayerObject.transform.position = new Vector3(0, 6, -40);
        }
    }
}
