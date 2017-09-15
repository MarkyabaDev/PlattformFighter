using UnityEngine;
using System.Collections;

public class StaminaBar : MonoBehaviour {
	
	public float maxLength;
	public float startX;
	
	//Die Daten werden auf die Staminabar zugestellt
	void ApplyStamina(float currentstamina)
	{
		if(currentstamina >=0){
		float xscale = currentstamina /100 * maxLength;
		transform.localScale = new Vector3(xscale,0.3f,0.5f);
		
		}
	}
	
}
