using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeLevelOnInsert : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			SceneManager.LoadScene ("bunlevel");
		}
	}
}