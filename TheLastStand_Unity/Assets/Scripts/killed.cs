using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killed : MonoBehaviour {
	public GameObject object1;
	public GameObject object2;
	public bool playerhorattacking;
	public bool enemyalive;
	// Use this for initialization
	void Start () {
		
		enemyalive = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		playerhorattacking = GameObject.Find("Player_idle").GetComponent<PlayerSwingController>().PlayerHorAttack;
		Debug.Log ("col enemy");
		if (enemyalive == true && playerhorattacking == true && (other.gameObject.CompareTag("PlayerTag") || other.gameObject.CompareTag("Player2Tag")))
		{
			
			Debug.Log ("killed enemy");
			Instantiate(object1, transform.position, transform.rotation);
			Instantiate(object2, transform.position, transform.rotation);
			Destroy(gameObject);
			enemyalive = false;
		}
	}
}