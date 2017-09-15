using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	string[] menu = new string[2];	//Die einzelnen Optionen für die Auswahl
	int index = 0;	//Indexauswahl
	int counter = 0;	//Counter für die Auswahl
	// Use this for initialization
	void Start () {
		menu[0] = "Start Game";
		menu[1] = "Quit Game";
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Menüauswahl
		if (Input.GetAxis("Vertical") < 0 && counter == 0) 
		{
			index = MenuSelection(menu, index, "down");
			counter++;
		}
						 			
		if (Input.GetAxis("Vertical") > 0 && counter == 0) 
		{			
			index = MenuSelection(menu, index, "up");
			counter++;
		}
			
		if(Input.GetAxis("Vertical") == 0)
		{
			counter = 0;
		}
			
		//Die Ausgewählte Option wird ausgeführt
		if (Input.GetKeyDown(KeyCode.JoystickButton16) || Input.GetKeyDown(KeyCode.JoystickButton0)) 
		{    			
			Run();			
		}
	}
	
	//Je nach Auswahl wird die Option gestartet
	void Run()
	{
		GUI.FocusControl(menu[index]);	//Auf was ist die Auswahl fokusiert
		
		switch(index)
		{
		case 0:
			Application.LoadLevel(1);	//Das Spiel wird gestartet
			break;
			
		case 1:
			Application.Quit ();	//Das Spiel wird komplett geschlossen
			break;
		}
	}
	
	void OnGUI()
	{
		GUI.FocusControl(menu[index]);
			
		GUI.SetNextControlName(menu[0]);	//Name für den Fokus		
		if(GUI.Button(new Rect((Screen.width-200)/2,(Screen.height+270)/2,200,30),"Start Game"))
		{
			index = 0;
			Run();
		}
			
		GUI.SetNextControlName(menu[1]);
		if(GUI.Button(new Rect((Screen.width-200)/2,(Screen.height+350)/2,200,30),"Quit Game"))
		{
			index = 1;
			Run ();
		}
	}
	
	int MenuSelection(string[] menuOptions, int selected, string direction)
	{
		if (direction == "up") 	//Die Auswahl wird nach oben verschoben
		{
       		if (selected == 0) 
			{
            	selected = menuOptions.Length - 1;
	        } 
			else 
			{	
	            selected -= 1;
	        }
    	}
		
		if (direction == "down") 	//Die Auswahl wird nach unten verschoben
		{
       		if (selected == menuOptions.Length - 1) 
			{
            	selected = 0;
	        } 
			else 
			{	
	            selected += 1;
	        }
    	}
		
		return selected;
		
		
	}
}
