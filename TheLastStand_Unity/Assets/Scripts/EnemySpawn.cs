using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		StartCoroutine (spawntimer ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator spawntimer() {
		yield return new WaitForSeconds (2);
		Instantiate(enemy, transform.position, transform.rotation);
		StartCoroutine (spawntimer ());
	}
}
