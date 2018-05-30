using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelA3_2_1 : MonoBehaviour {

	public bool test = false;
	public static int checkUp;

	void LateUpdate() {
	
		if (GameObject.Find ("TextTimer").GetComponent<Text> ().enabled) {

			checkUp = Timer.check - 1;

			if (checkUp <= 0 && test == true) {

				SceneManager.LoadScene ("A3.2.2B", LoadSceneMode.Single);
			}
		}

		test = true;
	}


	public void onButton1() {
		SceneManager.LoadScene ("A3.2.2A", LoadSceneMode.Single);
	}
	public void onButton2() {
		SceneManager.LoadScene ("A3.2.2B", LoadSceneMode.Single);
	}
	public void onButton3() {
		SceneManager.LoadScene ("A3.2.2C", LoadSceneMode.Single);
	}
	public void onButton4() {

	}
		
}
