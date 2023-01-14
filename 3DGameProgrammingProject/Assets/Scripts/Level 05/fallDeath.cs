using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallDeath : MonoBehaviour
{
    public GameObject player;
    public Timer timer;
    public playerMove pm;
    public followPlayer fp;

    private void Start()
    {

    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player.gameObject)
        {
            Debug.Log($"other= {other.gameObject} | gameobject= {player.gameObject.transform.position}");
            Debug.Log("player fallen");
            pm.resetPosition();
            timer.subtractTime(5);   
       }
        else
        {
            fp.resetPosition();
        }


    } 

}


