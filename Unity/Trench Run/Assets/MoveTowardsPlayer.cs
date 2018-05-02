using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour {

	public GameObject playerShip;
	public Vector3 playerPosition;
	public float force = 100.0f;
	float killTime;

	// Use this for initialization
	void Start () {
		playerShip = GameObject.FindGameObjectWithTag ("Player");
		playerPosition = playerShip.transform.position;
		gameObject.GetComponent<Rigidbody> ().AddForce ((playerPosition - transform.position).normalized * force * Time.deltaTime, ForceMode.Impulse);

	}

	// Update is called once per frame
	void Update () {
		killTime += Time.deltaTime;
		if (killTime > 3) {
			Destroy (gameObject);
		}
	}
}
