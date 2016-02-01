using UnityEngine;
using System.Collections;

public class MinimapFollow : MonoBehaviour {

	public Transform target;			// object for minimap camera to follow
	public float offset;				// minimap camera distance above the target
	/// </summary>
	
	// LateUpdate is called once at the end of each frame
	void LateUpdate () {
		// tracks the target in x and z direction
		//transform.position = new Vector3(target.position.x, offset, target.position.z);
	}
}
