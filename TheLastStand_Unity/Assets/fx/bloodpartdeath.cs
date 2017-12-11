using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodpartdeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (killparticle ());
	}
	
	// Update is called once per frame
	void Update () {

	}
	IEnumerator killparticle() {
		yield return new WaitForSeconds(1);
		Destroy(gameObject);
	}
}
