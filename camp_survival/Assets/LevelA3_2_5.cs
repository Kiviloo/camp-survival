using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_2_5 : MonoBehaviour {

	public void onButton1() {

		if (Axt.axtBool == false) {
			SceneManager.LoadScene ("A3.2.9ohneAxt", LoadSceneMode.Single);
		} else {
			
			SceneManager.LoadScene ("A3.2.9mitAxt", LoadSceneMode.Single);
		}
	}
	public void onButton2() {
		SceneManager.LoadScene ("A3.2.6", LoadSceneMode.Single);
	}
	public void onButton3() {
		if (Axt.axtBool == true) {
			SceneManager.LoadScene ("A3.2.7", LoadSceneMode.Single);
		}
	}
	public void onButton4() {

	}
}