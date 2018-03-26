using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	public int score;
	public bool showGUI = false;
	public Texture2D scorePanel;

	void OnGUI() {
		GUI.enabled = showGUI;
		GUI.Box (new Rect (10, 10, 100, 50), new GUIContent ("400", scorePanel));
	}

	void OnTriggerEnter(Collider collision) {
		if(collision.tag == "levelsOfLove") {
			showGUI = true;
			Debug.Log ("Main Object hit me!");
		}
	}
}
