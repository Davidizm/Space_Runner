using UnityEngine;
using System.Collections;

public class SunPosition : MonoBehaviour {

	Transform playerPos;		// reference to player

	// Use this for initialization
	void Start () {
		playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		print(playerPos == null ? "Player not found" : "player found");
	}
	
	// Update is called once per frame
	void Update () {
		// push sun back in z as player moves forward in z
//		if(playerPos.position.z > 0)
//			transform.position.z += playerPos.position.z;
	}
}
