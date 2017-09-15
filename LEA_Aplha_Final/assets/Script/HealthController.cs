using UnityEngine;
using System.Collections;

public class HealthController : MonoBehaviour {
	
	public float currentHealth = 40;
	public float stamina = 100;
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 2;
		
		stamina += speed * (Time.deltaTime+0.1f);
		
		if(stamina > 100)	//Stamina kommt nicht über 100
			stamina = 100;
		
		if(stamina < 0)	//Stamina kommt nicht unter null
			stamina = 0;
		
	}
	//Hier wird der Schaden/Gesundheit zugefügt
	void ApplyDamage(float damage)
	{
			if (currentHealth > 0)
			{
			if(damage < 0)
				currentHealth -= damage;
			
			if(damage > 0)
			{
				currentHealth -= damage * 0.25f;							
			}
			
			if(currentHealth > 40)
			currentHealth = 40;
			
		}
	}
	
	//Hier wird die Ausdauer zugefügt
	void ApplyStamina(float exhaust)
	{
		if (stamina >= 0 )
		{
			stamina -= exhaust;
		}

	}
}