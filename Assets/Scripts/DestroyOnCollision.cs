using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {
	public GameObject loveObjectExplosion;
	public Vector3 forceToFracture;
	public float radius = 5.0f; // radius of collision detection
	public float power = 10.0f; 	// force to which the object is hit

	// applies an explosion force to all nearby rigidbodies
	void Start() {
		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere (explosionPos, radius); // and check for detection collision

		foreach (Collider hit in colliders) {
			Rigidbody rgb = hit.GetComponent<Rigidbody> ();
			var getTag = gameObject.tag == "mainCharacter";

			if (rgb == getTag) {
				rgb.AddExplosionForce (power, explosionPos, radius, 3.0f); // explode the objects
			}
		}
	}
}
