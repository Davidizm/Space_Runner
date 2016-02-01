using UnityEngine;
using System.Collections;

public class ProjectileWeapon : MonoBehaviour {

	//values that will be set in the Inspector
	private Transform target;
	// the speed that the weapon can aim with
	public float aimSpeed;

	// The fire rate of the weapon
	public float fireRate;
	// The time when the next round will be fired
	private float nextRound;
	// The object to spawn when the bullet is fired
	public GameObject shot;
	// The transform for the spawnPoint
	public Transform spawnPoint;
	// The distance to where the astroid becomes active
	public float activationDistance;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		nextRound = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
			return;
		// Calculate the normal to rotate about
		Vector3 v1 = transform.forward;
		Vector3 v2 = target.position - transform.position;
		Vector3 normal = Vector3.Cross (v1, v2);
		 
		// Draw the vector for debugging purposes
		//Debug.DrawRay (transform.position, normal, new Color (0, 255, 0));
		//Debug.DrawRay (transform.position, v1 * 10, new Color (255, 0, 0));
		//Debug.DrawRay (transform.position, v2);

		// Check if we are within range of the target
		if (v2.magnitude <= activationDistance) {
			// Rotate towards the targets
			transform.RotateAround (transform.position, normal, aimSpeed * Time.deltaTime);

			// Fire a the target
			if (Time.time >= nextRound)
			{
				nextRound = Time.time + fireRate;
				Instantiate(shot, spawnPoint.position, spawnPoint.rotation);
			}
		}
	}
}
