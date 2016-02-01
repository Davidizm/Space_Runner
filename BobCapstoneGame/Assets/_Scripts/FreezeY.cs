using UnityEngine;
using System.Collections;

public class FreezeY : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = new Vector3 (rb.velocity.x, 0.0f, rb.velocity.z);
		rb.position = new Vector3 (rb.position.x, 0.0f, rb.position.z);
		transform.position = new Vector3 (transform.position.x, 0.0f, transform.position.z);
	}
}
