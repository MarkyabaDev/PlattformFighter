using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpriteController : MonoBehaviour {
	
	// Jede List steht für eine Animationsroutine eines Players
	public List<Texture2D> animationStayRight;	//Stehen Rechts
	public List<Texture2D> animationStayLeft;	//Stehen Links
	public List<Texture2D> animationGoRight;	//Laufen Rechts
	public List<Texture2D> animationGoLeft;		//Laufen Links
	public List<Texture2D> animationJumpRight;	//Springen Rechts
	public List<Texture2D> animationJumpLeft;	//Springen Links
	public List<Texture2D> animationPunchRight;	//Schlagen Rechts
	public List<Texture2D> animationPunchLeft;	//Schlagen Links
	public List<Texture2D> animationKickRight;	//Treten Rechts
	public List<Texture2D> animationKickLeft;	//Treten Links
	public List<Texture2D> animationDieRight;	//Sterben Rechts
	public List<Texture2D> animationDieLeft;	//Sterben Links
	public List<Texture2D> animationHitRight;	//Getroffen Rechts
	public List<Texture2D> animationHitLeft;	//Getroffen Links
	// Geschwindigkeit der Animationen
	public float speed = 1;
	
	public AnimationType currentAnimationType; //Aktuller Animationstyp
	
	public bool looping = true;		//Animation ist in einer Schleife?
	private AnimationType oldAnimationType;	//Alter Animationstyp
	private float myTime = 0; //Zeit für die Aktuelle Animation
	
	//Initialisierung jedes Animationstypes
	public enum AnimationType
	{
		stayRight,
		stayLeft,
		goRight,
		goLeft,
		jumpRight,
		jumpLeft,
		punchRight,
		punchLeft,
		kickRight,
		kickLeft,
		dieRight,
		dieLeft,
		hitRight,
		hitLeft
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(oldAnimationType != currentAnimationType)
		{
			myTime = 0;
			oldAnimationType = currentAnimationType;
			looping = true;
		}
		
		//Je nach Status des Charakters wird der Animationstyp gesetzt.
		switch(currentAnimationType)
		{
		case AnimationType.stayRight:
			SetTexture(animationStayRight);
			break;
		case AnimationType.stayLeft:
			SetTexture(animationStayLeft);
			break;
		case AnimationType.goRight:
			SetTexture(animationGoRight);
			break;
		case AnimationType.goLeft:
			SetTexture(animationGoLeft);
			break;
		case AnimationType.jumpRight:
			SetTexture(animationJumpRight);
			looping = false;
			break;
		case AnimationType.jumpLeft:
			SetTexture(animationJumpLeft);
			looping = false;
			break;
		case AnimationType.punchRight:
			SetTexture(animationPunchRight);
			break;
		case AnimationType.punchLeft:
			SetTexture(animationPunchLeft);
			break;
		case AnimationType.kickLeft:
			SetTexture(animationKickLeft);
			break;
		case AnimationType.kickRight:
			SetTexture(animationKickRight);
			break;
		case AnimationType.dieRight:
			SetTexture(animationDieRight);
			looping = false;
			break;
		case AnimationType.dieLeft:
			SetTexture(animationDieLeft);
			looping = false;
			break;
		case AnimationType.hitRight:
			SetTexture(animationHitRight);
			break;
		case AnimationType.hitLeft:
			SetTexture(animationHitLeft);
			break;
		}
	}
	
	//Die Texturen für jeden Animationstypes werden hier nacheinander angezeigt.
	void SetTexture (List<Texture2D> animationSprite)
	{
		myTime += Time.deltaTime;	
		int index = (int) (myTime * speed);
		
		if(!looping)
		{
			if(index >= animationSprite.Count-1)
			{
				index = animationSprite.Count-1;	
			}
		}
		index = index % animationSprite.Count;
		renderer.material.mainTexture = animationSprite[index];
	}
	
	//Animation wird zugewiesen
	public void SetAnimation (AnimationType animationType)
	{
		currentAnimationType = animationType;
	}
}