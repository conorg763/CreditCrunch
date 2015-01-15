#pragma strict

var doorOpen : GameObject;

function OnTriggerEnter (col : Collider) 
{
   if(col.gameObject.tag == "Player") 
   {
      doorOpen.animation.Play();
      Destroy(gameObject);
   }
}//if the player is near the door it will trigger the animation to open