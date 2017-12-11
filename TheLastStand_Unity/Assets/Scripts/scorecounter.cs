using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour {
	public int p1score;
	public int p2score;
	public int bodycount;
	public GameObject gamedirect;
	public Text P1Count;
	public Text P2Count;
	public Text BodyCount;

	// Use this for initialization
	void Start () {
		p1score = 0;
		p2score = 0;
		bodycount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		P1Count.text = p1score.ToString ();
		P2Count.text = p2score.ToString ();
		BodyCount.text = bodycount.ToString ();
	}
}
