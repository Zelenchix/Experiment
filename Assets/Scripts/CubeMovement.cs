using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public bool left = false;
    public bool right = false;
    public bool forward = false;
    public bool back = false;

    void Update()
    {
        if (Input.GetKey("a"))
        {
            left = true;
        }
        else
        {
            left = false;
        }

        if (Input.GetKey("d"))
        {
            right = true;
        }
        else
        {
            right = false;
        }

        if (Input.GetKey("w"))
        {
            forward = true;
        }
        else
        {
            forward = false;
        }

        if (Input.GetKey("s"))
        {
            back = true;
        }
        else
        {
            back = false;
        }
        
    }
}
