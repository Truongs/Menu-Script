﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelChange : MonoBehaviour {
	public Text endLevelText;
	bool hasEnded;
	public string nextlevel;


	// Use this for initialization
	void Start (){
	}

	
	// Update is called once per frame
	void Update () 
	{
		if (hasEnded && Input.GetKeyDown (KeyCode.E)) //checks if the level has ended and if the key E is pressed 
		{
			print ("'E' pressed, Player advance into next level");
			Time.timeScale = 1f;
			SceneManager.LoadScene(nextlevel);
		}
	}
	void OnTriggerEnter2D(Collider2D other) //checks if the player has passed the trigger
	{
		if (other.tag == "Player") 
		{
			print ("Player on door");
			endLevelText.gameObject.SetActive (true); 
			hasEnded = true;
		}
	}
}
