using UnityEngine;
using System.Collections;

public class ItemDropper : MonoBehaviour {
	
	public Transform Leben;
	public Transform Ausdauer;
	public Transform Geschwindigkeit;
	
	
	//je höher desto seltener
	public int dropchance;
	
	//Gebiet für Landezone
	public int Xmax;
	public int Xmin;
	public int height;
	
	// Use this for initialization
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
	
		int itemdrop = Random.Range(0,dropchance);	//Zufallsgenerator für Items die fallen
		int xposition= Random.Range(-Xmin,Xmax);	//Zufallsgenerator für die Position der Items
		int item = Random.Range(1,4);	//Zufallsgenerator für die Art des Items
		
		//if für das Erzeugen eines Items zuständig
		if(itemdrop <=1)
		{
		switch(item){
		case(1):GameObject.Instantiate(Leben,new Vector3((float)xposition,(float)height,0),Quaternion.FromToRotation (Vector3.left, transform.forward));	
			break;
		case(2):GameObject.Instantiate(Ausdauer,new Vector3((float)xposition,(float)height,0),Quaternion.FromToRotation (Vector3.left, transform.forward));	
			break;
		case(3):GameObject.Instantiate(Geschwindigkeit,new Vector3((float)xposition,(float)height,0),Quaternion.FromToRotation (Vector3.left, transform.forward));	
			break;
			
		}
		}
	}
}
