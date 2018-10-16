using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youWinGratsBro : MonoBehaviour {

	public GameObject you;

		void OnTriggerEnter(Collider other){
		if (other.tag == "Player" && you.transform.eulerAngles.y > 86 && you.transform.eulerAngles.y < 97) {
			print ("weeee");
			SceneManager.LoadScene ("winScene");
		}
	}
}

				