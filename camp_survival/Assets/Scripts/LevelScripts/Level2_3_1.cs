﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2_3_1 : MonoBehaviour {

	public void onButton1() {
		SceneManager.LoadScene ("2.3.2", LoadSceneMode.Single);
	}
	public void onButton2() {
		SceneManager.LoadScene ("2.3.3", LoadSceneMode.Single);
	}
	public void onButton3() {
		SceneManager.LoadScene ("2.4.1", LoadSceneMode.Single);
	}
	public void onButton4() {
		SceneManager.LoadScene ("nahrungsklau", LoadSceneMode.Single);
	}
}
