using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	private Transform firePosition;
	public GameObject ShellPrefeb;
	public KeyCode FireKeyCode = KeyCode.Space;
	public float ShellSpeed = 20;

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
		}
	}
}
