using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject love;
	public Vector3 spawnValues;
	public float spawnWait;
	public float startWait; // start spawning objects given specified time
	public float waveWait; 	// waves of which objects spawn
	public GUIText scoreText;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore ();
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves() {
		yield return new WaitForSeconds (startWait);

		while (true) {
			yield return new WaitForSeconds (startWait);
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z); 	// and place them at random x, y, and z along axes
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (love, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (waveWait);
		}
	}

	public void AddScore(int newScoreValue) {
		score += newScoreValue;
		UpdateScore ();
	}

	// display score on screen
	void UpdateScore () {
		scoreText.text = "Score : " + score;
	}
}
