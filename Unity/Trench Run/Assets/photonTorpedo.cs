using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class photonTorpedo : MonoBehaviour {

	public GameObject missile;
	public GameObject cam;
	public GameObject hole;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		toDownHole ();
	}

	void toDownHole() {
		cam.SetActive (true);
		missile.transform.position = Vector3.MoveTowards (missile.transform.position, hole.transform.position, 5f * Time.deltaTime);
	}
}
