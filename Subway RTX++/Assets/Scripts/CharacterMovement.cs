using System;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CharacterMovement : MonoBehaviour
{
    public float CharacterSpeed = 5.0f;
    public float jumpForce = 10f;
    public float leftLimit = - 5.0f;
    public float RightLimit = 5.0f;
    public bool isGrounded;
    public Rigidbody rb;
    public Animator animator;
    public bool jump = false;
    public bool roll = false;
    public bool Droll = false;
    public BoxCollider Trigger;
    [SerializeField] AudioSource jumpFx;
    [SerializeField] AudioSource Rolling;
    public AudioSource Music;
    public AudioSource credit;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Trigger = GetComponent<BoxCollider>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * CharacterSpeed, Space.World);
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > leftLimit) 
        {

            transform.Translate(new Vector3(-3, 0, 0));



        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < RightLimit)
        {

            transform.Translate(new Vector3(3, 0, 0));


        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded && roll == false)
        {
            Jump();
            jumpFx.Play();
            jump = true;

            animator.SetBool("jump", true);
            Console.WriteLine("jump true!");
        }

        if (Input.GetKeyDown(KeyCode.LeftControl) && isGrounded && jump == false)
        {
            if (roll == false) {
                Rolling.Play();
                roll = true;
            } 
            
            Droll = true;
            animator.SetBool("roll", true);
            Console.WriteLine("roll", true!);

        }

        if (Droll == true)
        {
            Trigger.enabled = false;
            
        }

    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
       
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the character has collided with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("jump", false);
            jump = false;

        }
        else
        {
            isGrounded = false;
        }
    }
  
    public void RollEnd()
    {
        roll = false;
        Droll = false;
        Trigger.enabled = true;
        animator.SetBool("roll", false);
    }

    void MusicEnd()
    {

        Music.Stop();
        credit.Play();
    }
}
