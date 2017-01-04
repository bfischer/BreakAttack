using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Vector3 _paddleToBallVector;
	private bool _hasStarted;

	public Paddle paddle;

	// Use this for initialization
	void Start () {
		_paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(!_hasStarted) {
			this.transform.position = paddle.transform.position + _paddleToBallVector;

			if(Input.GetMouseButton(0)) {
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
				_hasStarted = true;
			}
		}


	}
}
