using UnityEngine;
using System.Collections;

public class CubeDie : MonoBehaviour {
	
	

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float time = 10;
		GameObject.Destroy(this.gameObject,time);
		
	}
}
