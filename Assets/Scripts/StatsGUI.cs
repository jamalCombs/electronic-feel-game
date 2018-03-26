using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class StatsGUI : MonoBehaviour {

	// Use this for initialization
	void OnGUI () {
		GUI.Label (new Rect(8, 8, 256, 256), string.Format("{0}", Time.time));
	}
}
