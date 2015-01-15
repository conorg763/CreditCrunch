#pragma strict

var chestSound: AudioClip;
var treasureChest : GameObject;


function OnTriggerEnter (col : Collider) 
{
	if(col.gameObject.tag == "Player") 
	{
		AudioSource.PlayClipAtPoint(chestSound, transform.position);
		treasureChest.animation.Play();
		WorldGUI.timer += 30.0;
		Destroy(gameObject);
	}//triggers the treasure chest to play animation and add seconds to the timer as well as 
	//play the sound
}