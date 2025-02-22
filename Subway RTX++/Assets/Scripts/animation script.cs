using System;
using UnityEngine;

public class animationscript : MonoBehaviour
{
    public bool jump = false;
    public bool roll = false;
    private Animator animator;
    private CharacterMovement groundcheck;
    void Start()
    {
        animator = GetComponent<Animator>();
        groundcheck = GetComponent<CharacterMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roll == false)
        {
            jump = true;
          
            animator.SetBool("jump", true);
            Console.WriteLine("jump true!");
        }
        

        if (Input.GetKeyDown(KeyCode.LeftControl) && jump == false)
        {
            roll = true;
            animator.SetBool("roll", true);
            Console.WriteLine("roll true!");
          
        }
    }

    public void JumpEnd()
    {
        jump = false;
      
       animator.SetBool("jump", false);
    }
    public void RollEnd()
    {
        roll = false;

        animator.SetBool("roll", false);
    }
}
