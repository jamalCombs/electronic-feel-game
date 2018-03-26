using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
	public GameObject explosion;
	public GameObject mainCharacterExplosion;
	public int scoreValue;
	public GameController gameController;

	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");

		if(gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController>();
		}

		if (gameController == null) {
			Debug.Log("Connot find 'GameController' script");
		}
	}

	// trigger a collision event
	void OnTriggerEnter (Collider collision) {
		var isLoveObj = collision.tag == "levelsOfLove";
		var checkIfNull = gameController == null;

		if (collision.tag == "mainCharacter") {
			Instantiate(mainCharacterExplosion, collision.transform.position, collision.transform.rotation);
			Debug.Log ("Player wins!");
		}

		gameController.AddScore (scoreValue);
		Destroy (gameObject);
	}
}
