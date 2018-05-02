using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Pursue : SteeringBehaviour
{
    public Boid target;
    Vector3 targetPos;
	public AudioSource AS;

	public GameObject bullet;
	public GameObject bulletBarrel;

    public void Start()
    {
		InvokeRepeating ("shootAt",0f,5f);
		AS = gameObject.GetComponent<AudioSource> ();
    }

	void Update () {
		
		if (Input.GetKeyDown (KeyCode.P)) {
			shootAt ();
		}
	}

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, targetPos);
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
		AS.Play ();
		Instantiate(bullet,bulletBarrel.transform);
		bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, targetPos, 20f * Time.deltaTime);
		Destroy (bullet, 3f);
	}
}
