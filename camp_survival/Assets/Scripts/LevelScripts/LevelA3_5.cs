﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelA3_5 : MonoBehaviour {

	public void onButton1() {
		SceneManager.LoadScene ("A3.2", LoadSceneMode.Single);
	}
	public void onButton2() {
		SceneManager.LoadScene ("A3.4", LoadSceneMode.Single);
	}
	public void onButton3() {
		SceneManager.LoadScene ("A3.3", LoadSceneMode.Single);
	}
	public void onButton4() {
		SceneManager.LoadScene ("A3.5", LoadSceneMode.Single);
	}
}