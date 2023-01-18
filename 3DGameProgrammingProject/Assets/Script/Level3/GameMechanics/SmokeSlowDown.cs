using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeSlowDown : MonoBehaviour
{
    public float reducedSpeed = 1.5f;
    private float originalSpeed;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        originalSpeed = player.GetComponent<Move_lvl3>().MovementSpeed;

    }

    private void OnTriggerStay(Collider other)
    {
        player.GetComponent<Move_lvl3>().MovementSpeed = reducedSpeed;
    }

    private void OnTriggerExit(Collider other)
    {
        player.GetComponent<Move_lvl3>().MovementSpeed = originalSpeed;
    }
}
