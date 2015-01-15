#pragma strict

var coinIcon : Texture2D;
var treasureChestIcon : Texture2D;
var GUISkin : GUISkin;


static var timer : float = 60.0;

function Start () {
}

function Update () {
var coinCounter = CounterScript.coinCounter;
	timer -= Time.deltaTime;
	
	if(timer <= 0)
	{
		PlayerPrefs.GetInt ("YourScore");
		PlayerPrefs.SetInt ("YourScore", coinCounter);//Your Score

		if (coinCounter > PlayerPrefs.GetInt ("HighScore")) 
		{
						PlayerPrefs.SetInt ("HighScore", coinCounter);
		}//if

		Application.LoadLevel("GameOver");


		
	}	
}

function OnGUI() {
GUI.skin = GUISkin;
var coinNumberName = CounterScript.coinCounter;
var treasureChestNumberName = CounterScript.treasureChestCounter;
var coinName = coinNumberName.ToString();
var treasureChestName = treasureChestNumberName.ToString(); 
//Has To be done as label will only display String

GUI.Label (Rect(150,50,40,45),coinName);
GUI.Box(Rect(10,10,180,80),coinIcon);


GUI.Label (Rect(Screen.width - 170,50,100,50),treasureChestName);
GUI.Box(Rect(Screen.width - 190,10,170,90),treasureChestIcon);

GUI.Box(new Rect(Screen.width/2-50, 50, 100, 50), "" + timer.ToString("0"));
 
}
