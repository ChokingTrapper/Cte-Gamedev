using System;
using UnityEngine;

public class sample : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float movementSpeed = 5f;

    public float jumpVelocity = 5f;

    Rigidbody2D rb;
    bool canJump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        bool canJump1 = Input.GetKeyDown(KeyCode.Space);
        if(canJump1) canJump = true;

        // float inputVertical = Input.GetAxisRaw("Vertical");
        // transform.Rotate(0f,0f,rotationSpeed * -1 * inputHorizontal * Time.deltaTime);
        // transform.Translate(0f, movementSpeed * inputVertical * Time.deltaTime, 0f);

        // rb.angularVelocity = -inputHorizontal * rotationSpeed;
        // rb.linearVelocity = transform.up * inputVertical * movementSpeed; 

        rb.linearVelocity = new Vector2(inputHorizontal * movementSpeed, rb.linearVelocity.y);

        
    }

    
}
