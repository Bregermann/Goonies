using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour {

	public int movementSpeed = 20;
	public int chargeSpeed = 50;
	public int rotateSpeed = 20;
	public int flightSpeed = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//strafe left
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);

		}

		//strafe right
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
		}

		//go forward
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
		}

		//go backward
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.back * movementSpeed * Time.deltaTime);
		}

		//turn right
		if (Input.GetKey (KeyCode.E)) {
			transform.Rotate (Vector3.up, rotateSpeed);
		}

		//turn left
		if (Input.GetKey(KeyCode.Q)) {
			transform.Rotate (Vector3.up, rotateSpeed * -1);
		}


		//fly up
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (Vector3.up * flightSpeed * Time.deltaTime);
		}
		//fly down
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * flightSpeed * Time.deltaTime);
		}


	}
		
}
