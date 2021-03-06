﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwingController : MonoBehaviour {
	//call player components
	public CharacterController controller;
	public GameObject playerchar;
	public Animator characteranim;

	//call player swing position
	public bool PlayerSwingisUp;
	public bool PlayerSwingisDown;
	public bool PlayerSwingisLeft;
	public bool PlayerSwingisRight;
	public bool PlayerSwingisIdle;
	public bool PlayerHorAttack;
	public bool PlayerVerAttack;

	// Use this for initialization
	void Start () {
		//characteranim = GetComponent<Animator>();
		var characteranim = GetComponent<Animator>();
		PlayerSwingisUp = false;
		PlayerSwingisDown = false;
		PlayerSwingisRight = false;
		PlayerSwingisLeft = false;
		PlayerSwingisIdle = true;
		PlayerHorAttack = false;
		PlayerVerAttack = false;

	}

	// Update is called once per frame
	void Update () {
		float t = Input.GetAxis ("RightTrigger");
		float x = Input.GetAxis("4th axis");
		float y = Input.GetAxis("5th axis");
		//Debug.Log (t); //debug right trigger
		if (t < -0.80 && PlayerSwingisIdle == false) { //initiate swing
			Debug.Log("P1 Swing");


			characteranim.Play ("");

			if (PlayerSwingisUp == true) {
				characteranim.Play ("upattack");

				PlayerSwingisUp = false;
				PlayerSwingisIdle = true;
				PlayerVerAttack = true;

			} 
			if (PlayerSwingisRight == true) {
				characteranim.Play ("rightattack");
				PlayerSwingisRight = false;
				PlayerSwingisIdle = true;
				PlayerHorAttack = true;

			} 
			if (PlayerSwingisLeft == true) {
				characteranim.Play ("leftattack");
				PlayerSwingisLeft = false;
				PlayerSwingisIdle = true;
				PlayerHorAttack = true;
			} 
			if (PlayerSwingisDown == true) {
				characteranim.Play ("downattack");
				PlayerSwingisDown = false;
				PlayerSwingisIdle = true;
				PlayerVerAttack = true;
			} 
		}

		//Debug.Log ("PlayerHorAttack" + PlayerHorAttack);
		//Debug.Log ("PlayerSwingIdle" + PlayerSwingisIdle);
		//Debug.Log ("PlayerSwingUp" + PlayerSwingisUp);
		//Debug.Log ("PlayerSwingDown" + PlayerSwingisDown);
		//Debug.Log ("PlayerSwingLeft" + PlayerSwingisLeft);
		//Debug.Log ("PlayerSwingRight" + PlayerSwingisRight);

		if (x == 0 && y == 0 && PlayerSwingisIdle == true) {

			//play anim
			PlayerSwingisIdle = true;
			PlayerSwingisUp = false;
			PlayerSwingisDown = false;
			PlayerSwingisRight = false;
			PlayerSwingisLeft = false;


			if (PlayerSwingisIdle == true) {
				characteranim.Play ("idle");
				PlayerHorAttack = false;
				//Debug.Log ("idle");
			}
		}
		else 
		{
			//PlayerSwingisIdle = false;
		}
		//right swing
		if (x == 1   && PlayerSwingisRight == false) {
			PlayerSwingisRight = true;
			PlayerSwingisIdle = false;
			PlayerSwingisDown = false;
			PlayerSwingisUp = false;
			PlayerSwingisLeft = false;
			PlayerHorAttack = false;
			PlayerVerAttack = false;
			//play anim
			characteranim.Play ("rightswing");
			Debug.Log ("rightswing");
		}

		//left swing
		if (x == -1  && PlayerSwingisLeft == false) {
			PlayerSwingisLeft = true;
			PlayerSwingisIdle = false;
			PlayerSwingisDown = false;
			PlayerSwingisUp = false;
			PlayerSwingisRight = false;
			PlayerHorAttack = false;
			PlayerVerAttack = false;
			//play anim
			Debug.Log("leftswing");
			characteranim.Play ("leftswing");
		}

		//up swing
		if (y == -1  && PlayerSwingisUp == false) {
			PlayerSwingisUp = true;
			PlayerSwingisIdle = false;
			PlayerSwingisDown = false;
			PlayerSwingisRight = false;
			PlayerSwingisLeft = false;
			PlayerHorAttack = false;
			PlayerVerAttack = false;
			//play anim
			characteranim.Play ("upswing");
			Debug.Log("upswing");

		}


		//down swing
		if (y == 1  && PlayerSwingisDown == false) {
			PlayerSwingisDown = true;
			PlayerSwingisIdle = false;
			PlayerSwingisUp = false;
			PlayerSwingisLeft = false;
			PlayerHorAttack = false;
			PlayerVerAttack = false;
			//play anim
			characteranim.Play ("downswing");
			Debug.Log("downswing");

		}


	}
	public void PlayerAttack ()
	{
		PlayerHorAttack = false;
		PlayerVerAttack = false;
		PlayerSwingisUp = false;
		PlayerSwingisDown = false;
		PlayerSwingisRight = false;
		PlayerSwingisLeft = false;
		PlayerSwingisIdle = true;

	}
}
