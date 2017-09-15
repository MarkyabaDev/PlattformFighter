using UnityEngine;
using System.Collections;

public class Lifebar : MonoBehaviour {

	public float maxLength;
	
	//Die Daten werden auf die Lifebar zugestellt
	void ApplyLife(float currentlife)
	{
		if(currentlife >=0){
		float xscale = currentlife /40 * maxLength;
		transform.localScale = new Vector3(xscale,0.6f,0.5f);
		}
	}
}
