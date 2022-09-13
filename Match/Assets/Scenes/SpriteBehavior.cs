using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class SpriteBehavior : MonoBehaviour
{
   private SpriteRenderer rendererObj;

   private void Start()
   {
    //allows control over sprite renderers
        rendererObj = GetComponent<SpriteRenderer>();
   }

   public void ChangeRendererColor(ColorID obj)
   {
        rendererObj.color = obj.value;
   }
   //Don't want to variables.

}
