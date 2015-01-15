#pragma strict

var aScore : GUIText;
var bScore : GUIText;
var GUISkin : GUISkin;

function Start () {

}

function Awake () {

		bScore.text = "High Score : " + PlayerPrefs.GetInt ("HighScore");
		aScore.text = "Your Score : " + PlayerPrefs.GetInt ("YourScore");

	}//Awake() uses PlayerPref functions to get the players score and the highest score


function Update () {

}

