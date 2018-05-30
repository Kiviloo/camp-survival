using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_3_2 : MonoBehaviour {

	void Start () {

		StartCoroutine (HoldOn ());
	}

	IEnumerator HoldOn() {

		yield return new WaitForSeconds (10);
		SceneManager.LoadScene ("TestLevelEnde", LoadSceneMode.Single);
	}
}