using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyOutOfBounds : MonoBehaviour {
	public Text outOfBounds;
	private bool markedForDestruction;
	private float endTime;

	// Use this for initialization
	void Start () {
		//removeWarning ();
		markedForDestruction = false;
	}
	
	// Update is called once per frame
	void Update () {
		// Wondered too far for too long, too bad...
		if (markedForDestruction && Time.time >= endTime) {
			Destroy(GameObject.FindGameObjectWithTag("Player"));
			Debug.Log ("Cleared from update");
			removeWarning ();
		}
	}

	void OnTriggerExit(Collider other) {
		// If it's the player give them some time to get back into the bounds
		if (other.gameObject.CompareTag ("Player")) {
			warnPlayer ();
			markedForDestruction = true;
			endTime = Time.time + 10;
		} 
		// otherwise, destroy the object immediately
		else {
			Destroy (other.gameObject);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			markedForDestruction = false;
			Debug.Log ("Cleared from on trigger enter");
			removeWarning ();
		}
	}

	void warnPlayer() {
		outOfBounds.text = "Out of bounds.\nReturn to game area or be destroyed.";
	}

	void removeWarning() {
		outOfBounds.text = "";
	}
}
