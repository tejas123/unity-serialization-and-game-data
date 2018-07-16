using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour {
	#region PUBLIC_VARIABLE
	public float speed=0.1f;
	#endregion
	#region PRIVATE_VARIABLE
	Vector3 position;
	#endregion
	#region UNITY_CALLBACKS

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			position = transform.position;
			position.x += speed;
			transform.position = position;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			position = transform.position;
			position.x -= speed;
			transform.position = position;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			position = transform.position;
			position.y += speed;
			transform.position = position;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			position = transform.position;
			position.y -= speed;
			transform.position = position;
		}
	}
	#endregion
}
