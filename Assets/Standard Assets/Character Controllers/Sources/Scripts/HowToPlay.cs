using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour {

	public Texture backgroundTexture;
	public GUISkin GUISkin;

	
	// Use this for initialization
	void OnGUI() {
		GUI.skin = GUISkin;

		//Display background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		//Displays our buttons
		GUI.Box(new Rect(270f, 45f, Screen.width * .5f ,100f ), "");
		GUI.Label (new Rect(320f,60f, 205f ,250f ), "CONTROLS");
		GUI.Label (new Rect(320f,120f, 205f ,250f ), "Shift = Run");
		GUI.Label (new Rect(440f,150f, 205f ,250f ), "Up Arrow Key = Walk Forward");
		GUI.Label (new Rect(470f,180f, 205f ,250f ), "Down Arrow Key = Walk Backwards");
		GUI.Label (new Rect(420f,210f, 205f ,250f ), "Left Arrow Key = Walk Left");
		GUI.Label (new Rect(430f,240f, 205f ,250f ), "Right Arrow Key = Walk Right");
		GUI.Label (new Rect(350f,270f, 205f ,250f ), "Spacebar = Jump");


		if (GUI.Button (new Rect (Screen.width * .375f, Screen.height * .70f, Screen.width * .25f, Screen.height * .1f), "Return To Main Menu")) {
			
			Application.LoadLevel ("MainMenu"); //loads level
			
		}//Play




	
	}
}
