using UnityEngine;
using System.Collections;

public class FollowMainPlayer : MonoBehaviour {
	public Transform target;
	private bool isMoving = false;
	private Vector3 dir;
	public float speed = 5.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		dir = target.position - transform.position; // calculate the targets direction
		isMoving = true; 	// enable movement
		GameObject mainCharacter = GameObject.FindWithTag ("mainCharacter");

		if (mainCharacter == isMoving) {
			transform.Translate (dir * speed * Time.deltaTime, Space.World);
		}
	}
}
