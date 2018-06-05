using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_4_1 : MonoBehaviour {

	public void onButton1() {
		SceneManager.LoadScene ("A3.4.2", LoadSceneMode.Single);
	}
	public void onButton2() {
		SceneManager.LoadScene ("A3.4.5", LoadSceneMode.Single);
	}
	public void onButton3() {
		SceneManager.LoadScene ("3.4.7", LoadSceneMode.Single);
	}
	public void onButton4() {

	}
}