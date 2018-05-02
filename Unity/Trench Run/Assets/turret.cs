using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour {

	public GameObject bullet;
	public GameObject cannon1;
	public GameObject cannon2;

	public float seconds ;

	public Boid Target;


	// Use this for initialization
	void Start () {
		StartCoroutine ("shooting");

	}
	
	// Update is called once per frame
	void Update () {
	}

	private IEnumerator shooting(){
		seconds = Random.Range (1f, 5f);
		Instantiate (bullet, cannon1.transform.position, Quaternion.identity);
		Instantiate (bullet, cannon2.transform.position, Quaternion.identity);

		yield return new WaitForSeconds (seconds);
		StartCoroutine ("shooting");

	}

}
