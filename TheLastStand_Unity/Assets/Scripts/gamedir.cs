using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedir : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	private Vector3 player1start;
	private Vector3 player2start;
	private Vector3 player1startrot;
	private Vector3 player2startrot;
	public bool p1exists;
	public bool p2exists;
	private	GameObject p1charspawn;
	private GameObject p2charspawn;
	// Use this for initialization
	void Start () {
		player1start = player1.transform.position;
		player2start = player2.transform.position;
		player1startrot = player1.transform.rotation.eulerAngles;
		player2startrot = player2.transform.rotation.eulerAngles;
	 p1charspawn = Instantiate(player1, player1start, transform.rotation);
	 p2charspawn = Instantiate(player2, player2start, transform.rotation);
		//p1exists = true;
		//p2exists = true;

	}

	// Update is called once per frame
	void Update () {
		//p1exists = player1.GetComponent<P1killed> ().p1alive;
		//p2exists = player2.GetComponent<P2killed> ().p2alive;
		if (player1 == null) {
			
			Debug.Log ("P1 exists");
			Instantiate(p1charspawn, player1start, transform.rotation);
			//p1exists = true;
		}
		if (player2 == null) {

			Debug.Log ("P2 exists");
			Instantiate(p2charspawn, player2start, transform.rotation);
			//p2exists = true;
		}
		
	}
}
