using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1_1 : MonoBehaviour {


	void Start () {

		StartCoroutine (HoldOn ());
	}
	
	IEnumerator HoldOn() {

		yield return new WaitForSeconds (10);
		SceneManager.LoadScene ("1.2", LoadSceneMode.Single);
	}
}
