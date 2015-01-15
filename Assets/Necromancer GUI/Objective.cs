using UnityEngine;
using System.Collections;

public class Objective : MonoBehaviour {
	
	public Texture backgroundTexture;
	public GUISkin GUISkin;
	
	
	// Use this for initialization
	void OnGUI() {
		GUI.skin = GUISkin;
		
		//Display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		//Displays our buttons
		GUI.Box(new Rect(270f, 45f, Screen.width * .5f ,100f ), "");
		GUI.Label (new Rect(320f,60f, 205f ,250f ), "OBJECTIVE:");
		GUI.Label (new Rect(565f,120f, 205f ,250f ), "Tommy The Builder Has Been Hit badly by the Credit Crunch. ");
		GUI.Label (new Rect(530f,150f, 205f ,250f ), "Collect as many coins as you can within the time limit. ");
		GUI.Label (new Rect(540f,180f, 205f ,250f ), "Look for the Treasure Chests to add on 15 seconds to the ");
		GUI.Label (new Rect(525f,210f, 205f ,250f ), "Timer, so help Tommy from the dreaded Credit Crunch  ");
		GUI.Label (new Rect(325f,240f, 205f ,250f ), "Before its too late!  ");


		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .60f, Screen.width * .25f, Screen.height * .11f), "PLAY")) {
			
			Application.LoadLevel ("outdoor"); //loads level
		}
		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .70f, Screen.width * .25f, Screen.height * .1f), "Return To Main Menu")) {
			
			Application.LoadLevel ("MainMenu"); //Returns to Main Menu
			
		}//Play		
	}

}
