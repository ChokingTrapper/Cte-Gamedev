using System;
using UnityEngine;

public class sample : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float movementSpeed = 5f;

    public float jumpVelocity = 5f;
    public float maxdist = 1.25f;
    public LayerMask groundlayer;

    Rigidbody2D rb;
    bool canJump;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    void Update()
    {
       // isGrounded = Physics2D.Raycast(transform.position, Vector2.down,maxdist, groundlayer);
        //Debug.DrawRay(transform.position, Vector2.down * maxdist, Color.green );
        
        Debug.Log(isGrounded);
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        bool canJump1 = Input.GetKeyDown(KeyCode.Space);

        // float inputVertical = Input.GetAxisRaw("Vertical");
        // transform.Rotate(0f,0f,rotationSpeed * -1 * inputHorizontal * Time.deltaTime);
        // transform.Translate(0f, movementSpeed * inputVertical * Time.deltaTime, 0f);

        // rb.angularVelocity = -inputHorizontal * rotationSpeed;
        // rb.linearVelocity = transform.up * inputVertical * movementSpeed; 

        rb.linearVelocity = new Vector2(inputHorizontal * movementSpeed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
            Jump();
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        isGrounded = true;
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpVelocity);
        isGrounded = false;
    }


}
