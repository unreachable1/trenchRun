using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaderPursue : SteeringBehaviour {
	public Boid target;
	Vector3 targetPos;

	public GameObject bullet;
	public Transform bulletBarrel;

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("shootAt", 2f, 0.3f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			shootAt ();
		}
	}

	public override Vector3 Calculate()
	{
		float dist = Vector3.Distance(target.transform.position, transform.position);
		float time = dist / boid.maxSpeed;

		targetPos = target.transform.position
			+ (time * target.velocity);

		return boid.SeekForce(targetPos);
	}

	public void shootAt() {
		Instantiate(bullet,bulletBarrel);
		bullet.transform.position = Vector3.MoveTowards (bullet.transform.position, targetPos, 5f * Time.deltaTime);
	}
}
