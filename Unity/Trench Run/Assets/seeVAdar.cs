using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seeVAdar : MonoBehaviour {
	public GameObject playerCAm;
	public GameObject vaderCAm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col) {
		if(col.tag == "Player") {
			StartCoroutine ("vaderSwap");

		}
	}

	public IEnumerator vaderSwap() {
		playerCAm.SetActive (false);
		vaderCAm.SetActive (true);

		yield return new WaitForSeconds(4);

		playerCAm.SetActive (true);
		vaderCAm.SetActive (false);
	}
}
