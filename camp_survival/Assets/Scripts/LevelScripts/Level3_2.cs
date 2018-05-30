using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3_2 : MonoBehaviour {

	public void onButton1() {
		SceneManager.LoadScene ("2.1 - 1", LoadSceneMode.Single);
	}
	public void onButton2() {
		SceneManager.LoadScene ("2.1 - 2", LoadSceneMode.Single);
	}
	public void onButton3() {
		SceneManager.LoadScene ("2.1 - 3", LoadSceneMode.Single);
	}
	public void onButton4() {

	}
}
