using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class ChangeColorOnClick : MonoBehaviour
{
   private Renderer rn;
   void Start()
   {
      rn = GetComponent<Renderer>();
   }
   private void OnMouseDown()
   {
      Color randomColor = new Color(UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f), UnityEngine.Random.Range(0f, 1f));
      
      rn.material.color = randomColor;
   }

   private void OnClick()
   {
      
   }
   
}
