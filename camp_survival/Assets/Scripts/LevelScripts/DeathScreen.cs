using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour {


	void Start () {

		StartCoroutine (Wait ());
	}
	

	IEnumerator Wait() {

		yield return new WaitForSeconds (5);
		ReturnToMain ();
	}


	public void ReturnToMain () {

		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}
}
