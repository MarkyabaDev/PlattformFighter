using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	string playerWin;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("Win") == 1)	//Hier wird überprüft welcher Spieler gewonnen hat
			playerWin = "Player 1";
		else
			playerWin = "Player 2";
	}
	
	// Update is called once per frame
	void Update () {
			//Das Spiel wird neugestartet
		if(Input.GetKeyDown(KeyCode.JoystickButton16) || Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.A))
			Application.LoadLevel(0);
	}
	
	void OnGUI()
	{
		GUI.Label(new Rect((Screen.width-100)/2,(Screen.height-100)/2,100,100),"GAME OVER " + playerWin + " Wins");	//Text
		GUI.Label(new Rect((Screen.width-175)/2,(Screen.height)/2,200,200),"Press A to go back to Menu");	//Text
	}
}
