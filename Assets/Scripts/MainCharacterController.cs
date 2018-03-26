using UnityEngine;
using System.Collections;

public class MainCharacterController : MonoBehaviour {
	public float speed = 10.0f; 	// main character's speed
	public float rotationSpeed = 100.0f; // main character's rotation speed

	void Update() {
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);
	}
}
