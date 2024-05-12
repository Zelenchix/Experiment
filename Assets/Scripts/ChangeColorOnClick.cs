using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ChangeColorOnClick : MonoBehaviour
{
   private void OnMouseDown()
   {
      GetComponent<Renderer>().material.color = Color.yellow;
   }
}
