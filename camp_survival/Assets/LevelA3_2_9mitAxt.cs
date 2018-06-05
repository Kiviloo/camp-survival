using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_2_9mitAxt : MonoBehaviour {

	void Start () {

		StartCoroutine (HoldOn ());
	}

	IEnumerator HoldOn() {

		yield return new WaitForSeconds (12);
		SceneManager.LoadScene ("A4.0_mitAxt", LoadSceneMode.Single);
	}
}
