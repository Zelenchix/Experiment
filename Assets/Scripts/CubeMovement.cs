using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private float moveSpeed = 100f;
    private float moveHorizontal;
    private float moveVertical;
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
     {
         Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
         rb.AddForce(movement * moveSpeed);
         // Debug.Log("movement" + movement);
         // Debug.Log("movementSpeed" + moveSpeed);
         // Debug.Log("moveHorizontal" + moveHorizontal);
         // Debug.Log("moveVertical" + moveVertical);
     }
}