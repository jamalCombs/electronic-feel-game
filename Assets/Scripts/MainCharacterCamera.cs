using UnityEngine;
using System.Collections;

// position camera on main character
public class MainCharacterCamera : MonoBehaviour {
	public Transform target;
	public float relativeHeight = 10f; 	// create a variable to store relative height of camera
	public float zDistance = 5.0f; 	// create a variable to store distance of camera on z axis
	public float dampSpeed = 2; // adds smoothness frame by frame

	// Update is called once per frame
	void Update () {
		Vector3 newPos = target.position + new Vector3 (0, relativeHeight, -zDistance);
		transform.position = Vector3.Lerp (transform.position, newPos, Time.deltaTime * dampSpeed);
	}
}
