using UnityEngine;
using System.Collections;

public class MainMenu1 : MonoBehaviour {
	
	public GUISkin GUISkin;
	public Texture backgroundTexture;
	
	// Use this for initialization
	void OnGUI() {

		GUI.skin = GUISkin;
		//Display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		//Displays our buttons
		
		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .45f, Screen.width * .25f, Screen.height * .1f), "Play Game")) {
			
			Application.LoadLevel ("ObjectiveScene"); //loads level
			
		}//Play

		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .65f, Screen.width * .25f, Screen.height * .1f), "How To Play")) {
			
			Application.LoadLevel ("HowToPlay"); //loads level
			
		}//HowToPlay
		
		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .85f, Screen.width * .25f, Screen.height * .1f), "Quit")) {
			
			Application.Quit();

		}//Quit

	}
}
