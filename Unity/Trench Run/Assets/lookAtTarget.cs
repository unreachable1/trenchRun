using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtTarget : MonoBehaviour {
	
	public Transform Luke;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Luke);
	}
}
