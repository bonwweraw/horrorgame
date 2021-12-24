using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//If there is a no reference error --> uncomment this line:
//[RequireComponent(typeof(BoxCollider2D))]

public class Movement : MonoBehaviour
{
//manual collision detection 
   private BoxCollider2D boxCollider;

//Calculate the change of the player's position after each frame
   private Vector3 movementChange;

   private void start()
   {
//Variable BoxCollider fetches the BoxCollider2D function from unity
       boxCollider = GetComponent<BoxCollider2D>();
   }

//Beginning of movement loop
   private void FixedUpdate() 
   {
//recieve player inputs
       float x = Input.GetAxisRaw("Horizontal");
       float y = Input.GetAxisRaw("Vertical");
//reset movementChange
       movementChange = new Vector3(x,y,0);
//sprite direction
    if (movementChange.x > 0) 
        transform.l  ocalScale = Vector3.one;
    else if (movementChange.x < 0 )
        transform.localScale = new Vector3(-1,1,1);
//moving
   transform.Translate(movementChange * Time.deltaTime);
   }
}
