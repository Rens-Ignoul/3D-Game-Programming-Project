using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public GameObject MainPlayerObject;
    public GameObject ResetWall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Obstacle" || other.gameObject.tag == "ResetWall")
        {
            ScoreManager.amount -= 50;
            MainPlayerObject.transform.position = new Vector3(21.42f, 15.41f, -41.09f);
            ResetWall.transform.position = new Vector3(21.3f, 11, -50.87f);
        }
    }
}
