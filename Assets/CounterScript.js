#pragma strict
static var coinCounter = 0;
static var treasureChestCounter = 0;
function Start () 
{

}
function Update () 
{

}
function OnCollisionEnter (collision : Collision)
{
	if (collision.transform.name == ("Coin"))
	{
	  coinCounter+=1;
	}//Adds 1 to the coinCounter
}
function OnTriggerEnter (col : Collider) 
{
   if(col.transform.name == "TriggerTreasurebox") 
   {
   	  treasureChestCounter+=1;
   }
}//Adds 1 to the treasureChestCounter

function GameOver () 
{
   PlayerPrefs.GetInt ("YourScore");
   PlayerPrefs.SetInt ("YourScore", coinCounter);//Your Score
   if (coinCounter > PlayerPrefs.GetInt ("HighScore")) 
   {
	   PlayerPrefs.SetInt ("HighScore", coinCounter);
   }//if
Application.LoadLevel("GameOver");
}//GameOver() Destroys the gameobject and also saves the users score and the 
//high score and will then loads the GameOver Scene
	

