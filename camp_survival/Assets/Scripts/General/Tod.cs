using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tod : MonoBehaviour {

	public CanvasGroup panel;
	public int seconds;
	public float value;
	private bool b = true;


	void Update() {


		if (b == true) {
			StartCoroutine (Wait ());
		} else {

			panel = GetComponent<CanvasGroup> ();
			panel.alpha = panel.alpha + value;
		}	

		if (panel.alpha >= 1f) {
			SceneManager.LoadScene ("DeathScreen", LoadSceneMode.Single);
		}
	}

	IEnumerator Wait() {


		yield return new WaitForSeconds (seconds);
		b = false;
	}
}