using UnityEngine;
using System.Collections;

public class MakeObjectProjectile : MonoBehaviour {
	public GameObject projectile;
	public float fireRate = 5.0f;
	public float nextFire = 0.0f;
	private float timeBetweenShots = 0.3333f;

	void Update() {
		nextFire = Time.deltaTime + fireRate * timeBetweenShots;
		GameObject clone = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
		clone.transform.position = transform.position;
	}
}
