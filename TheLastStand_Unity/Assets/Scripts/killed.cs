using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killed : MonoBehaviour {
	public GameObject object1;
	public GameObject object2;
	public GameObject object3;
	public GameObject object4;
	public GameObject bloodpart;
	public GameObject bloodpartvert;
	public GameObject player;
	public GameObject player2;
	public bool playerhorattacking;
	public bool playerverattacking;
	public bool player2horattacking;
	public bool player2verattacking;
	public bool enemyalive;
	public GameObject gamedirect;
	// Use this for initialization
	void Start () {

		enemyalive = true;
	}

	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		player2 = GameObject.FindGameObjectWithTag ("Player2");
	}
	void OnTriggerEnter(Collider other){
	//	if (player !== null) {
			playerhorattacking = player.GetComponent<PlayerSwingController> ().PlayerHorAttack;
			playerverattacking = player.GetComponent<PlayerSwingController> ().PlayerVerAttack;
	//	}
	//	if (player2 != null) {
			player2horattacking = player2.GetComponent<Player2SwingController> ().PlayerHorAttack;
			player2verattacking = player2.GetComponent<Player2SwingController> ().PlayerVerAttack;
	//	}
		Debug.Log ("col enemy");
		if (enemyalive == true && (playerhorattacking == true || player2horattacking == true) && (other.gameObject.CompareTag("PlayerTag") || other.gameObject.CompareTag("Player2Tag")))
		{
			
			Debug.Log ("killed enemy");
			Instantiate(object1, transform.position, transform.rotation);
			Instantiate(object2, transform.position, transform.rotation);
			Instantiate(bloodpart, transform.position, transform.rotation);
			gamedirect.GetComponent<scorecounter> ().bodycount += 1;
			Destroy(gameObject);
			enemyalive = false;
		}
		if (enemyalive == true && (playerverattacking == true || player2verattacking == true) && (other.gameObject.CompareTag("PlayerTag") || other.gameObject.CompareTag("Player2Tag")))
		{

			Debug.Log ("killed enemy");
			Instantiate(object3, transform.position, transform.rotation);
			Instantiate(object4, transform.position, transform.rotation);
			Instantiate(bloodpartvert, transform.position, transform.rotation);
			gamedirect.GetComponent<scorecounter> ().bodycount += 1;
			Destroy(gameObject);
			enemyalive = false;
		}
	}
}