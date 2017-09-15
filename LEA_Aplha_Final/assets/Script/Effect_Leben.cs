using UnityEngine;
using System.Collections;

public class Effect_Leben : MonoBehaviour {
	
	
	public int healValue = -5;
	public string tagPlayer1;
	public string tagPlayer2;
	
	// Use this for initialization
	void Start () {
	
	}

	
	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == tagPlayer1 || collider.gameObject.tag == tagPlayer2)	//Befindet sich der Player im Collider des Objektes auf welchem dieses Script liegt.
		{
		collider.gameObject.SendMessage("ApplyDamage",healValue,SendMessageOptions.DontRequireReceiver);	//Die Funktion "ApplyDamage" wird aufgerufen mit dem Wert -5
		
		GameObject.Destroy(this.gameObject);	//Das Objekt wird zerstört
		}
	}
}
