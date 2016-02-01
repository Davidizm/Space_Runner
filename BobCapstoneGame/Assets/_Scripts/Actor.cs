using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {
	// Damage done to an object collides when it collides with this one
	public int damage;
	// The hit points of this object
	public int currentHitPoints;
	// The number of starting hit points the object has
	public int startHitPoints;
	// The number of hit points that can be absorbed by the shield
	public int shieldsHitPoints;
	// The animation played when this object is destroyed
	public GameObject deathAnimation;

	// Use this for initialization
	protected void Start () {
		currentHitPoints = startHitPoints;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other)  {
		Actor obj = other.collider.GetComponent<Actor> ();
		if (obj) {
			obj.DoDamage (damage);
		}
	}

	public virtual void DoDamage(int amount)
	{
		currentHitPoints -= amount;
		// Update the hud if the actor is the player object
		if (currentHitPoints <= 0) {
			currentHitPoints = 0;
			Destroy (gameObject);
		}
	}

	protected void OnDestroy() {
		if(deathAnimation)
			Instantiate (deathAnimation, transform.position, transform.rotation);
	}
}
