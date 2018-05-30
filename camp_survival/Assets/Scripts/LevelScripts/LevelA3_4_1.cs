using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_4_1 : MonoBehaviour {

	void Start () {

		StartCoroutine (HoldOn ());
	}

	IEnumerator HoldOn() {

		yield return new WaitForSeconds (6);
		SceneManager.LoadScene ("TestLevelEnde", LoadSceneMode.Single);
	}
}