using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_2_7 : MonoBehaviour {

	void Start() {

		Axt.axtBool = false;
	}

	public void onButton1() {
		if (Axt.axtBool == false) {
			SceneManager.LoadScene ("A3.2.9ohneAxt", LoadSceneMode.Single);
		}
	}
	public void onButton2() {
		SceneManager.LoadScene ("A3.2.8", LoadSceneMode.Single);
	}
	public void onButton3() {

	}
	public void onButton4() {

	}
}