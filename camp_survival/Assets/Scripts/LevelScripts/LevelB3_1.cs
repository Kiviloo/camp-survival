using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelB3_1 : MonoBehaviour {

	void Start () {

		StartCoroutine (HoldOn ());
	}

	IEnumerator HoldOn() {

		yield return new WaitForSeconds (8);
		SceneManager.LoadScene ("TestLevelEnde", LoadSceneMode.Single);
	}
}