﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

	public FoodObjectController foodObjectController;
	public float restartDelay = 5f;

	Animator anim;
	float restartTimer;

	void Awake()
	{
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (foodObjectController.FoodItemCount <= 0) 
		{
			anim.SetTrigger ("GameOver");
			restartTimer += Time.deltaTime;
		}
			if (restartTimer >= restartDelay) 
		{
			SceneManager.LoadScene ("menu");
		}
	}
}