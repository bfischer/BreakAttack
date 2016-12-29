using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer Instance = null;

	// Use this for initialization
	void Start () {
		if(Instance != null) {
			Destroy(gameObject);
		}
		else {
			Instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
