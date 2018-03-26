using UnityEngine;
using System.Collections;

public class ExpandObject : MonoBehaviour {
	private Transform trans;
	public float maxScale = 10.0f;
	public float minScale = 2.0f;
	public float shrinkSpeed = 1.0f;
	private float targetScale;
	private Vector3 v3Scale;

	void Update() {
		RaycastHit hit; // inspect raycast
		Ray ray;

		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray, out hit)) { // check to see if ray picked up data
				trans = hit.transform;
				targetScale = minScale;
				v3Scale = new Vector3 (targetScale, targetScale, targetScale);
			}
		}

		if (Input.GetMouseButtonDown (1)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast(ray, out hit)) {
				Debug.Log ("Scaling up");
				trans = hit.transform;
				targetScale = maxScale;
				v3Scale = new Vector3 (targetScale, targetScale, targetScale);
			}
		}

		if(trans != null) {
			trans.localScale = Vector3.Lerp (trans.localScale, v3Scale, Time.deltaTime * shrinkSpeed);
		}
	}
}
