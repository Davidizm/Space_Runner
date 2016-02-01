using UnityEngine;
using System.Collections;

public class EnemyGenerator : MonoBehaviour {

	public float genRadius;
	// A number representing the number of enemies per square unit area.
	// A number of .25 would spawn an enemy every four squares untis.
	public float enemyDensity;
	// The calculated number of enemies needed.
	private int numEnemies;
	// The type of enemy that will spawn.
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		numEnemies = (int)(Mathf.PI * genRadius * genRadius*enemyDensity);

		for (int i = 0; i < numEnemies; i++) {
			Vector3 spawnPos = transform.position;
			spawnPos.x += Random.Range (-genRadius, genRadius);
			spawnPos.z += Random.Range (-genRadius, genRadius);
			Quaternion orientation = Quaternion.Euler (new Vector3 (0, Random.Range (-180, 180), 0));
			Instantiate (enemy, spawnPos, orientation);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
