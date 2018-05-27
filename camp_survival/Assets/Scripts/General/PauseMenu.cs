using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	private Transform[] voice;
	private bool paused = false;
	private int isPlaying;


	void Start() {

		GameObject.Find ("PauseMenu").GetComponent<Canvas> ().enabled = false;
	}


	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {

			if (paused == false) {

				Pause ();
			} else {

				Resume ();
			}
		}
	}


	public void Pause() {

		GameObject.Find ("PauseMenu").GetComponent<Canvas> ().enabled = true;
		Time.timeScale = 0f;
		paused = true;

		AudioSource audio = GameObject.FindGameObjectWithTag ("Voice").GetComponent<AudioSource> ();

		audio.Pause ();
	}


	public void Resume() {

		GameObject.Find ("PauseMenu").GetComponent<Canvas> ().enabled = false;
		Time.timeScale = 1f;
		paused = false;

		AudioSource audio = GameObject.FindGameObjectWithTag ("Voice").GetComponent<AudioSource> ();

		audio.UnPause ();
	}
}