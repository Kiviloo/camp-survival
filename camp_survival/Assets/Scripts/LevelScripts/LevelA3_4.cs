using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_4 : MonoBehaviour {

	void Start () {

		StartCoroutine (HoldOn ());
	}

	IEnumerator HoldOn() {

		yield return new WaitForSeconds (6);
		SceneManager.LoadScene ("A3.4.1", LoadSceneMode.Single);
	}
}