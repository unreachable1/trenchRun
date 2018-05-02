using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeStar : MonoBehaviour {
	public GameObject explodeCam;
	public GameObject torpedoCam;
	public GameObject deathStar;
	public GameObject explostion;
	public AudioSource AS;
	public GameObject LukeNHan;
	// Use this for initialization
	void Start () {
		AS = gameObject.GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame

	public IEnumerator blowDeathStar(){
		
		yield return new WaitForSeconds (4);
		LukeNHan.SetActive (true);
		Destroy (deathStar);
		AS.Play ();
		explostion.SetActive (true);

	}

	void OnTriggerEnter(Collider col) {
		if (col.name == "torpedo") {
			explodeCam.SetActive (true);
			Destroy (torpedoCam);
			LukeNHan.SetActive (true);
			StartCoroutine ("blowDeathStar");
		}
	}
}
