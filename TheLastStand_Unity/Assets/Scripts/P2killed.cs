﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2killed : MonoBehaviour {
	public GameObject object1;
	public GameObject object2;
	public GameObject object3;
	public GameObject object4;
	public GameObject bloodpart;
	public GameObject bloodpartvert;
	public GameObject player;
	public GameObject gamedirect;
	public bool playerhorattacking; //player 2 attacking p1
	public bool playerverattacking;
	public bool p2alive;
	// Use this for initialization
	void Start () {
		p2alive = true;

	}

	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		gamedirect = GameObject.FindGameObjectWithTag ("Respawn");
	}
	void OnTriggerEnter(Collider other){
			
		if (player != null) {
			playerhorattacking = player.GetComponent<PlayerSwingController> ().PlayerHorAttack;
			playerverattacking = player.GetComponent<PlayerSwingController> ().PlayerVerAttack;
			Debug.Log ("P1 col");
		}
		if (p2alive == true &&  playerhorattacking == true &&  other.gameObject.CompareTag("PlayerTag"))
		{

			Debug.Log ("killed p2");
			Instantiate(object1, transform.position, transform.rotation);
			Instantiate(object2, transform.position, transform.rotation);
			Instantiate(bloodpart, transform.position, transform.rotation);
			p2alive = false;
			gamedirect.GetComponent<gamedir> ().p2exists = false;
			Destroy(gameObject);

		}
		if (p2alive == true &&  playerverattacking == true &&  other.gameObject.CompareTag("PlayerTag"))
		{

			Debug.Log ("killed p2");
			Instantiate(object3, transform.position, transform.rotation);
			Instantiate(object4, transform.position, transform.rotation);
			Instantiate(bloodpartvert, transform.position, transform.rotation);
			gamedirect.GetComponent<gamedir> ().p2exists = false;
			Destroy(gameObject);
			p2alive = false;
		}

		//enemy kills p2
		if (p2alive == true && other.gameObject.CompareTag("Enemy"))
		{

			Debug.Log ("killed p2");
			Instantiate(object1, transform.position, transform.rotation);
			Instantiate(object2, transform.position, transform.rotation);
			Instantiate(bloodpart, transform.position, transform.rotation);
			p2alive = false;
			gamedirect.GetComponent<gamedir> ().p2exists = false;
			Destroy(gameObject);

		}
	}
}