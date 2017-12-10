using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1killed : MonoBehaviour {
	public GameObject object1;
	public GameObject object2;
	public GameObject object3;
	public GameObject object4;
	public GameObject player2;
	public bool player2horattacking; //player 2 attacking p1
	public bool player2verattacking;
	public bool p1alive;
	// Use this for initialization
	void Start () {
		p1alive = true;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (player2 != null) {
			player2horattacking = player2.GetComponent<Player2SwingController> ().PlayerHorAttack;
			player2verattacking = player2.GetComponent<Player2SwingController> ().PlayerVerAttack;
			Debug.Log ("P2 col");
		}
		if (p1alive == true &&  player2horattacking == true &&  other.gameObject.CompareTag("Player2Tag"))
		{

			Debug.Log ("killed p1");
			Instantiate(object1, transform.position, transform.rotation);
			Instantiate(object2, transform.position, transform.rotation);
			Destroy(gameObject);
			p1alive = false;
		}
		if (p1alive == true &&  player2verattacking == true &&  other.gameObject.CompareTag("Player2Tag"))
		{

			Debug.Log ("killed p1");
			Instantiate(object3, transform.position, transform.rotation);
			Instantiate(object4, transform.position, transform.rotation);
			Destroy(gameObject);
			p1alive = false;
		}
	}
}