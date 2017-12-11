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
	public GameObject gamedirect;
	// Use this for initialization
	void Start () {
		player1start = player1.transform.position;
		player2start = player2.transform.position;
		player1startrot = player1.transform.rotation.eulerAngles;
		player2startrot = player2.transform.rotation.eulerAngles;
	 p1charspawn = Instantiate(player1, player1start, transform.rotation);
	 p2charspawn = Instantiate(player2, player2start, transform.rotation);
		p1exists = true;
		p2exists = true;

	}

	// Update is called once per frame
	void Update () {

		//p1exists = player1.GetComponent<P1killed> ().p1alive;
		//p2exists = player2.GetComponent<P2killed> ().p2alive;
		if (p1exists == false) {
			
			Debug.Log ("P1 exists");
			Instantiate(player1, player1start, transform.rotation);
			gamedirect.GetComponent<scorecounter> ().p2score += 1;
			gamedirect.GetComponent<scorecounter> ().bodycount += 1;
			p1exists = true;
		}
		if (p2exists == false) {

			Debug.Log ("P2 exists");
			Instantiate(player2, player2start, transform.rotation);
			gamedirect.GetComponent<scorecounter> ().p1score += 1;
			gamedirect.GetComponent<scorecounter> ().bodycount += 1;
			p2exists = true;
		}
		
	}
}
