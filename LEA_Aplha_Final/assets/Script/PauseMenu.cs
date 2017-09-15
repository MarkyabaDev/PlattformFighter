using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	bool isPaused = false;
	string[] menu = new string[2];
	int index = 0;
	int counter = 0;
	
	// Dieses Programm funktioniert auf die selbe Art und Weise wie das MainMenu.cs Script
	// Use this for initialization
	void Start () {
		menu[0] = "Resume";
		menu[1] = "Quit Game";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.JoystickButton9)||Input.GetKeyDown(KeyCode.JoystickButton7)||Input.GetKeyDown(KeyCode.Escape))
			Pause ();
		
		if(isPaused)
		{
			
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
			
			if (Input.GetKeyDown(KeyCode.JoystickButton16)||Input.GetKeyDown(KeyCode.JoystickButton0)) 
			{    			
			    Run();			
			}	
		}
	}
	
	void Run()
	{
		GUI.FocusControl(menu[index]);
		
		switch(index)
		{
		case 0:
			Pause ();
			break;
			
		case 1:
			Application.LoadLevel(0);
			Pause();
			break;
		}
	}
	
	void OnGUI()
	{
		if(isPaused)
		{
			GUI.FocusControl(menu[index]);
			
			GUI.SetNextControlName(menu[0]);			
			if(GUI.Button(new Rect((Screen.width-200)/2,(Screen.height-30)/2,200,30),"Resume"))
			{
				index = 0;
				Run();
			}
			
			GUI.SetNextControlName(menu[1]);
			if(GUI.Button(new Rect((Screen.width-200)/2,(Screen.height+50)/2,200,30),"Quit Match"))
			{
				index = 1;
				Run ();
			}
		}
	}	
	
	void Pause()
	{
		if(!isPaused)
		{
			Time.timeScale = 0;
		}
		else
		{
			Time.timeScale = 1;	
		}
		isPaused = !isPaused;
	}
	
	int MenuSelection(string[] menuOptions, int selected, string direction)
	{
		if (direction == "up") 
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
		
		if (direction == "down") 
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
