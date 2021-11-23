using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    float jumpPower = 2f;
    public Rigidbody playerrb;
    public int playerScore = 0;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {

       isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

       Vector3 move = transform.right * x + transform.forward * z;

       controller.Move(move * speed * Time.deltaTime);

       velocity.y += gravity * Time.deltaTime;

       controller.Move(velocity * Time.deltaTime);

        jump();
        Death();
        Scoring();
        
    }


    void jump()
    {

            if(Input.GetButtonDown("Jump") && isGrounded)
            {
            velocity.y += Mathf.Sqrt(jumpPower * -3.0f * gravity);
            }              
    }

    void Death()
    {
       
    }

    void Scoring()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "death")
        {
            print("I died");
        }

        if(col.gameObject.tag == "objective")
        {
            playerScore ++;
            print("coin collected");
        }
    }


}
