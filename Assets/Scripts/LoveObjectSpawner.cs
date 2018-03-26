using UnityEngine;
using System.Collections;
using System.Linq;

public class LoveObjectSpawner : MonoBehaviour {
	public float timeBetweenSpawns;
	public float spawnDistance;
	public CreateLoveObjects[] loveObjects;
	float timeSinceLastSpawn;

	void FixedUpdate () {
		timeSinceLastSpawn += Time.deltaTime;

		if (timeSinceLastSpawn >= timeBetweenSpawns) {
			timeSinceLastSpawn -= timeBetweenSpawns;
			SpawnLoveObjects ();
		}
	}

	void SpawnLoveObjects () {
		CreateLoveObjects objects = loveObjects[Random.Range(0, loveObjects.Length)];
		CreateLoveObjects spawn = Instantiate<CreateLoveObjects> (objects); // instatiate createloveobject class

		spawn.transform.localPosition = Random.onUnitSphere * spawnDistance; // generate objects and position them relative to
	}
}
