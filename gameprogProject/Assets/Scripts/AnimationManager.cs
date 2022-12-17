using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
  
    private Animator animator;
    
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            
            animator.SetBool("Runs", true);
        }
        else
        {
        
            animator.SetBool("Runs", false);
        }

    
        if (Input.GetKeyDown(KeyCode.Space))
        {
     
            animator.SetBool("Jumps", true);
        }
        else
        {
        
            animator.SetBool("Jumps", false);
        }

    
        if (!animator.GetBool("Runs") && !animator.GetBool("Jumps"))
        {
     
            animator.SetBool("Idle", true);
        }
        else
        {
    
            animator.SetBool("Idle", false);
        }



    }
}
