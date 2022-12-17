using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosCamera : MonoBehaviour
{
    public Transform positionCamera;

    void Update()
    {
        transform.position = positionCamera.position;
    }
}
