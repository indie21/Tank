using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 10;
	public Rigidbody _rigidBody ; 

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		float h = Input.GetAxis ("Vertical");
		_rigidBody.velocity = transform.forward * h * speed;

		float v = Input.GetAxis("Horizontal");
		_rigidBody.angularVelocity = transform.up * v * angularSpeed;
	}
}
