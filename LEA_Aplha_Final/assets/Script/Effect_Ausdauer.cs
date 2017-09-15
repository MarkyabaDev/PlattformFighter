using UnityEngine;
using System.Collections;

public class Effect_Ausdauer : MonoBehaviour {

	public int staminaValue = -5;
	public string tagPlayer1;
	public string tagPlayer2;
	
	// Use this for initialization
	void Start () {
	
	}

	
	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == tagPlayer1 || collider.gameObject.tag == tagPlayer2)	//Befindet sich der Player im Collider des Objektes auf welchem dieses Script liegt.
		{
		collider.gameObject.SendMessage("ApplyStamina",-5,SendMessageOptions.DontRequireReceiver);	//Die Funktion "ApplyStamina" wird aufgerufen mit dem Wert -5
		
		GameObject.Destroy(this.gameObject);	//Das Objekt wird zerstört
		}
	}
}
