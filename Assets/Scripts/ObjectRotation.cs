using UnityEngine;
using System.Collections;

public class ObjectRotation : MonoBehaviour {
	public float speed = 20.0f; 	// the speed to which the object is rotating

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.right * speed * Time.deltaTime);
		transform.Rotate (Vector3.up * speed * Time.deltaTime, Space.World);
	}
}
