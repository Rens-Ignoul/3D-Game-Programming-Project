using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public GameObject MainPlayerObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Obstacle")
        {
            MainPlayerObject.transform.position = new Vector3(0, 6, -40);
        }
        if (other.gameObject.tag=="ResetWall" || other.gameObject.tag=="Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
