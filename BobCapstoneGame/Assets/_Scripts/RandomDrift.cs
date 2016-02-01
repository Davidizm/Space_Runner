using UnityEngine;
using System.Collections;

public class RandomDrift : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		Vector3 v = new Vector3 (Random.Range (-1, 1), 0.0f, Random.Range (-1, 1));
		rb.velocity = v * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
