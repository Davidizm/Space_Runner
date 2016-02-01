using UnityEngine;
using System.Collections;

public class EnemyShipMovement : MonoBehaviour {
	// the target the ship should head towards
	private Transform target;
	// the speed at which the enemy approaches the target.
	public float speed;
	// the distance when the enemy becomes active
	public float activationDistance;


	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;
		// r is the position vector
		Vector3 r1 = transform.position;
		Vector3 r2 = target.position;
		// A vector from this object to the target
		Vector3 r3 = r2 - r1;
		if (r3.magnitude < activationDistance && r3.magnitude > 5) {
			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
	}
}
