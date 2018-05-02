using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireMissile : MonoBehaviour {
	public GameObject missile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		if (col.tag == "Player") {
			missile.SetActive (true);
		}
	}
}
