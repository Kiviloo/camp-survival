using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_3_1 : MonoBehaviour {

	void Start () {

		StartCoroutine (HoldOn ());
	}

	IEnumerator HoldOn() {

		yield return new WaitForSeconds (85);
		SceneManager.LoadScene ("A3.3.2", LoadSceneMode.Single);
	}
}