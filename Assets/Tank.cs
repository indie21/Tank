using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	private Transform firePosition;
	public GameObject ShellPrefeb;
	public KeyCode FireKeyCode = KeyCode.Space;
	public float ShellSpeed = 20;
	public int hp=100;
	public GameObject _TankExplosion;
	public AudioClip _AudioTankExplosion;
	public AudioClip  _AudioShot; 

	// Use this for initialization
	void Start () {
		// 得到位置
		firePosition = transform.Find ("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (FireKeyCode)) {
			GameObject go = GameObject.Instantiate (ShellPrefeb, firePosition.position, firePosition.rotation) as GameObject;

			// 赋予子弹速度
			go.GetComponent<Rigidbody> ().velocity = go.transform.forward * ShellSpeed;
			AudioSource.PlayClipAtPoint (_AudioShot, transform.position);

		}
	}
		
	void TakeDamage() {
		if (hp <= 0) {
			return;
		}
		hp -= Random.Range (30, 40);

		//死了。
		if (hp <= 0) {
			AudioSource.PlayClipAtPoint (_AudioTankExplosion, transform.position);
			GameObject go = GameObject.Instantiate (_TankExplosion, transform.position+ Vector3.up , transform.rotation) as GameObject;
			GameObject.Destroy (this.gameObject);
			GameObject.Destroy (go, 1.0f);
		}
	}
}
