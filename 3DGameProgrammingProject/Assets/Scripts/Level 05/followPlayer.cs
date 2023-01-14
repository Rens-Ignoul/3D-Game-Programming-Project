using System.Collections;
using UnityEngine;


public class followPlayer : MonoBehaviour
{
    // Variables for movement
    public float speed = 5f;
    private Vector3 targetPosition;
    private CharacterController characterController;
    private int subtractTime = 5;
    private float followRange= 5;

    // Variables for attacking
    private GameObject player;
    private bool beenInRange;
    private bool inRange = false;
    private float lastTimerUpdate;
    public Animator animator;
    public Timer timer;
    public int subtractedTime = 2;
    public float rotationSpeed = 5.0f;

    public flashingLight light;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        characterController = GetComponent<CharacterController>();
        beenInRange = false;
        targetPosition = start.getRandomPosition();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        bool inRange = distance <= followRange;


        if (inRange)
        {
            light.useLight(true);
            targetPosition = player.transform.position;
            Debug.Log($"In Range => Distance: {distance}");
            if (distance < 2)
            {
                speed = 0;
                if (Time.time - lastTimerUpdate >= 3f)
                {
                    timer.subtractTime(5);
                    lastTimerUpdate = Time.time;
                    Debug.Log($"ATTACK => Distance: {distance}");
                    animator.Play("m_melee_combat_attack_A");
                }
            }
            beenInRange = true;
            speed = 3f;
        }
        else
        {

            light.useLight(false);
            if ( transform.position == targetPosition || beenInRange || Time.time - lastTimerUpdate>=2f )
            {
                targetPosition = start.getRandomPosition();
                Debug.Log($"New Position=> Distance: {distance}");
                lastTimerUpdate = Time.time;
                beenInRange = false;

            }
            
        }

        // Update movement variables

            Vector3 movement = (targetPosition - transform.position).normalized * speed * Time.deltaTime;
            animator.SetBool("isRunning", movement.sqrMagnitude > 0);
            characterController.Move(movement);
            // Rotate the character towards the target position
            if (movement.magnitude > 0)
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), rotationSpeed * Time.deltaTime);
            }
 
       
    }

    public void resetPosition()
    {
        characterController.enabled = false;
        transform.position = new Vector3(-7, 33, -14);
        characterController.enabled = true;
    }
}
