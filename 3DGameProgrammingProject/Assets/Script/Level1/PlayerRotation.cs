using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        float y = target.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, y, 0);//draait lichaam waarnaar hij kijkt
    }
}
