using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	private Transform closestplayer;
	private GameObject  player1;
	private GameObject  player2;
	private float distancefromp1;
	private float distancefromp2;
	public bool isattacking;
	public Animator enemy;

	public float RotationSpeed;

	// Use this for initialization
	void Start () {
		isattacking = false;
		StartCoroutine(attack ());
	}
	
	// Update is called once per frame
	void Update () {
		player1 = GameObject.FindGameObjectWithTag ("Player");
		player2 = GameObject.FindGameObjectWithTag ("Player2");
		//if (player1 != null) {
			float distancefromp1 = Vector3.Distance (transform.position, player1.transform.position);
	//	}
		//if (player2 != null) {
			float distancefromp2 = Vector3.Distance (transform.position, player2.transform.position);
	//	}
		if (distancefromp1 < distancefromp2) {
			closestplayer = player1.transform;
		}
		if (distancefromp2 < distancefromp1) {
			closestplayer = player2.transform;
		}
		if (player1 != null || player2 != null) {
			transform.position = Vector3.MoveTowards (transform.position, closestplayer.transform.position, 0.03f);

			transform.LookAt(closestplayer);
		}
	}
	public void enemyattack ()
	{
		isattacking = false;

	}

	IEnumerator attack() {
		isattacking = true;
		enemy.Play ("enemyattacks");
		yield return new WaitForSeconds (5);

		StartCoroutine (attack ());
	}



}
