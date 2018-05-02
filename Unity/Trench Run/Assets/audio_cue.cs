using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_cue : MonoBehaviour {
	public AudioSource AS;


	// Use this for initialization
	void Start () {
		AS = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col) {
		if(col.tag == "Player") {
		Debug.Log (col.name);
		AS.Play ();
			}
		}
	}

