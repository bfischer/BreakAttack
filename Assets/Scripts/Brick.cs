using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public int maxHits;

	private int _timesHit;

	// Use this for initialization
	void Start () {
		_timesHit = 0;
		maxHits = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision) {
		_timesHit++;
	}
}
