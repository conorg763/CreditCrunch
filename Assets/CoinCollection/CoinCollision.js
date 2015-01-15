#pragma strict

var coin : GameObject;
function Start () 
{


}
function Update() 
{


}
function OnCollisionEnter (collision : Collision) 
{
	if(collision.gameObject.tag == "Player") 
	{
		Destroy(gameObject);
	}//if the player collides with the coin it will be destroyed
}