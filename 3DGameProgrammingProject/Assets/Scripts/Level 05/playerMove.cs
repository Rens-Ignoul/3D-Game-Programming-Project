using UnityEngine;
using System.Collections;


public class playerMove : MonoBehaviour
{
    public Animator animator;
    public float speed = 10f;
    public float rotationSpeed = 4f;
    private CharacterController characterController;



    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        // Get input for horizontal and vertical movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, 0,verticalInput) * speed * Time.deltaTime;


        // Update the animator based on whether or not the character is moving
        if (movement.sqrMagnitude > 0)
        {
            if (!animator.GetBool("isRunning"))
            {
                animator.SetBool("isRunning", true);
            }
        }
        else
        {
            if (animator.GetBool("isRunning"))
            {
                animator.SetBool("isRunning", false);
            }
        }

        // Move the character
        characterController.Move(movement);

        // Rotate the character towards the direction of movement
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        if (direction.magnitude > 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotationSpeed * Time.deltaTime);
        }

        //player cant move while falling down
        if (transform.position.y > 50)
        {
            characterController.enabled = false;
        }
        else
        {
            characterController.enabled = true;
        }
    }

   public void resetPosition()
    {
        characterController.enabled = false;
        transform.position = new Vector3(0, 40, 0);
        characterController.enabled = true;
    }
}
