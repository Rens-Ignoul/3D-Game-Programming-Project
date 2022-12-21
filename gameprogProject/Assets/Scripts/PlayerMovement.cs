using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Bron: YouTube basic movement
    public Transform target;
    private float moveSpeed = 6f;
    private float jumpForce = 3f;
    private float playerHeight =6f;
    public LayerMask jumpOnWhat;
    bool standing;
    public Transform orientation;
    bool landed;
    public KeyCode jump = KeyCode.Space;
    float hInput;
    float vInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        landed = true;
    }
    private void Update()
    {
       
        float y = target.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, y, 0); //draait lichaam waarnaar hij kijkt
        standing = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, jumpOnWhat);
        MyInput();
        Speed();
        MovePlayer();
    }

    private void MyInput()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");


        if (Input.GetKey(jump) && landed && standing)
        {
            landed = false;
            Jump();
            Invoke(nameof(ResetJump), 0);
        }
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * vInput + orientation.right * hInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    private void Speed()
    {
        Vector3 Vel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (Vel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = Vel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        landed = true;
    }
}
