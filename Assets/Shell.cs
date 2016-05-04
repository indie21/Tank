using UnityEngine;
using System.Collections;

public class Shell : MonoBehaviour {


	public GameObject _ShellExplosionPrefeb;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void OnTriggerEnter(Collider other) {
		GameObject.Instantiate (_ShellExplosionPrefeb, transform.position, transform.rotation);
		GameObject.Destroy (this.gameObject);

		if (other.tag == "Tank") {
			other.SendMessage ("TakeDamage");
		}
	}
}
