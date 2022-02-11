using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    Rigidbody rb;

    public float normalSpeed = 12f;
    public float sprintSpeed = 24f;

    public float gravity = -19.62f;
    public float jumpHeight = 10f;

    public Transform groundChecker;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;


    Vector3 velocity;
    bool isGrounded;
    private readonly object moveBy;

   // AudioSource myAudioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // myAudioSource = GetComponent<AudioSource>();
    }



    void Update()
    {
       

        isGrounded = Physics.CheckSphere(groundChecker.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = normalSpeed;
        }

       // if((rb.velocity.magnitude > 1.0f) && (myAudioSource.isPlaying == false))
      //  {
      //      myAudioSource.volume = Random.Range(0.8f, 1.0f);
      //      myAudioSource.pitch = Random.Range(0.8f, 1.1f);
     //       myAudioSource.Play();
      //  }
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log (5);
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y +=  gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
