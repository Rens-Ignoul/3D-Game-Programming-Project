using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject playerObject;
    public float rotateSpeed = 5;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = playerObject.transform.position - transform.position;   
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        float horizontal = Input.GetAxisRaw("Mouse X") * rotateSpeed;
        playerObject.transform.Rotate(0, horizontal, 0);

        float angle = playerObject.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.position = playerObject.transform.position - (rotation * offset);

        transform.LookAt(playerObject.transform);
    }
}
