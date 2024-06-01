using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementWithoutRigidBody : MonoBehaviour
{
    private float moveSpeed = 100f;
    private float moveHorizontal;
    private float moveVertical;
    
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal AD");
        moveVertical = Input.GetAxis("Vertical WS");

    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
