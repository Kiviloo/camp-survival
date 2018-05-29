using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_2_1 : MonoBehaviour {

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
