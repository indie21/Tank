using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 5;
	public float angularSpeed = 10;
	public Rigidbody _rigidBody ; 
	public int number = 1;

	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		float h = Input.GetAxis ("Player"+number +"Vertical");
		_rigidBody.velocity = transform.forward * h * speed;

		float v = Input.GetAxis("Player"+number+"Horizontal");
		_rigidBody.angularVelocity = transform.up * v * angularSpeed;
	}
}
