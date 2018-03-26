using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[RequireComponent(typeof(Rigidbody))]
public class CreateLoveObjects: MonoBehaviour {
	public float attractionForce; // depends on the distance from the center
	Rigidbody body;

	void Awake() {
		body = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() {
		body.AddForce (transform.localPosition * -attractionForce);
	}
}
