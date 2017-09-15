using UnityEngine;
using System.Collections;

public class Effect_Speed : MonoBehaviour {

	public int speedboost = 5;
	public string tag1;
	public string tag2;
	
	// Use this for initialization
	void Start () {
	
	}

	
	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == tag1 || collider.gameObject.tag == tag2)	//Befindet sich der Player im Collider des Objektes auf welchem dieses Script liegt.
		{
		collider.gameObject.SendMessage("ApplySpeed",speedboost,SendMessageOptions.DontRequireReceiver);	//Die Funktion "ApplySpeed" wird aufgerufen mit dem Wert 5
		
		GameObject.Destroy(this.gameObject);	//Das Objekt wird zerstört
		}
	}
	
	
}
