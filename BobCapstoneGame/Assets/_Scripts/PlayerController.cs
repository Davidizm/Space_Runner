using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// An instance to the ships rigid body
	public Rigidbody rb;

	// Values used to control movement
	public float speed;
	public float rotation;
	private Vector3 cameraDistance;

	// Values that control aspects of various weapons.
	private float nextFire;
	public float fireRate;
	public Transform shotSpawn;
	public GameObject shot;
	 
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		cameraDistance = new Vector3 (0, 20, 0); //Camera.main.transform.position - transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		Camera.main.transform.position = transform.position + cameraDistance;
	}

	void Update() {
		if (Input.GetButton("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}

	void FixedUpdate() {
		// Get the up down left right actions
		float xf = Input.GetAxis ("Horizontal");
		float zf = Input.GetAxis ("Vertical");

		// Move with strafe
		Vector3 velocity = new Vector3 (xf, 0.0f, zf);
		rb.velocity = velocity * speed;

		// Rotate the ship to point towards the mouse
		Vector3 shipPosition = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 lookAt = new Vector3 (Input.mousePosition.x - shipPosition.x, 0.0f, Input.mousePosition.y - shipPosition.y);
		transform.rotation = Quaternion.LookRotation (lookAt);
	}
		


}
