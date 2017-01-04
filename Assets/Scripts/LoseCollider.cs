using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D(Collider2D collider) {
		levelManager.LoadLevel("Win");
		print("trigger");
	}

	void OnCollisionEnter2D(Collision2D collision) {
		print("collision");
	}
}
