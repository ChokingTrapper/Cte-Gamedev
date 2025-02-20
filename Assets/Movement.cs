using System;
using UnityEngine;
using UnityEngine.AI;

public class sample : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public float movementSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        float inputVertical = Input.GetAxisRaw("Vertical");
        transform.Rotate(0f,0f,rotationSpeed * -1 * inputHorizontal * Time.deltaTime);
        transform.Translate(0f, movementSpeed * inputVertical * Time.deltaTime, 0f);
    }
}
