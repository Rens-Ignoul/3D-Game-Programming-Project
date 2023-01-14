using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding : MonoBehaviour
{
    public Transform orientation;
    public Transform playerObject;
    private Rigidbody rigidbody;
    private CapsuleCollider collider;
    private Move movement;

    public float maxSlideTime;
    public float slideForce;
    private float slideTimer;

    public float slideYScale;
    private float startYScale;

    public KeyCode slideKey = KeyCode.LeftControl;
    private float horizontalInput;
    private float verticalInput;

    private bool sliding;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        collider = GetComponent<CapsuleCollider>();
        movement = GetComponent<Move>();

        startYScale = playerObject.localScale.y;
    }
    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(slideKey) && (horizontalInput != 0 || verticalInput != 0))
        {
            StartSliding();
        }
        if (Input.GetKeyUp(slideKey) && sliding)
        {
            StopSliding();
        }
    }
    private void FixedUpdate()
    {
        if (sliding)
        {
            SlideMovement();
        }
    }
    private void SlideMovement()
    {
        Vector3 inputDir = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rigidbody.AddForce(inputDir.normalized * slideForce, ForceMode.Force);

        slideTimer -= Time.deltaTime;

        if (slideTimer<=0)
        {
            StopSliding();
        }
    }

    private void StartSliding()
    {
        sliding = true;
        playerObject.localScale = new Vector3(playerObject.localScale.x, slideYScale, playerObject.localScale.z);
        rigidbody.AddForce(Vector3.down * 5f, ForceMode.Impulse);

        slideTimer = maxSlideTime;
    }

    private void StopSliding()
    {
        sliding = false;
        playerObject.localScale = new Vector3(playerObject.localScale.x, startYScale, playerObject.localScale.z);
    }
}
