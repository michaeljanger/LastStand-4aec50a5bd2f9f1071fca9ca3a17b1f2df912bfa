using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1killed : MonoBehaviour {
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
	public bool p1alive;
	// Use this for initialization
	void Start () {
		p1alive = true;

	}

	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player2");
		gamedirect = GameObject.FindGameObjectWithTag ("Respawn");
	}
	void OnTriggerEnter(Collider other){

		if (player != null) {
			playerhorattacking = player.GetComponent<Player2SwingController> ().PlayerHorAttack;
			playerverattacking = player.GetComponent<Player2SwingController> ().PlayerVerAttack;
			Debug.Log ("P2 col");
		}
		if (p1alive == true &&  playerhorattacking == true &&  other.gameObject.CompareTag("Player2Tag"))
		{

			Debug.Log ("killed p1");
			Instantiate(object1, transform.position, transform.rotation);
			Instantiate(object2, transform.position, transform.rotation);
			Instantiate(bloodpart, transform.position, transform.rotation);
			p1alive = false;
			gamedirect.GetComponent<gamedir> ().p1exists = false;
			Destroy(gameObject);

		}
		if (p1alive == true &&  playerverattacking == true &&  other.gameObject.CompareTag("Player2Tag"))
		{

			Debug.Log ("killed p1");
			Instantiate(object3, transform.position, transform.rotation);
			Instantiate(object4, transform.position, transform.rotation);
			Instantiate(bloodpartvert, transform.position, transform.rotation);
			gamedirect.GetComponent<gamedir> ().p1exists = false;
			Destroy(gameObject);
			p1alive = false;
		}
	}
}