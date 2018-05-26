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
		
		GameObject parentVoice = GameObject.FindGameObjectWithTag ("Voice");
		voice = new Transform[parentVoice.transform.childCount];

		GameObject.Find ("PauseMenu").GetComponent<Canvas> ().enabled = true;
		Time.timeScale = 0f;
		paused = true;

		for (int i = 0; i < parentVoice.transform.childCount; i++) {

			voice [i] = parentVoice.transform.GetChild (i);

			if (voice [i].GetComponent<AudioSource> ().isPlaying) {

				isPlaying = i;
				voice [i].GetComponent<AudioSource> ().Pause ();
			}
		}
	}


	public void Resume() {

		GameObject.Find ("PauseMenu").GetComponent<Canvas> ().enabled = false;
		Time.timeScale = 1f;
		paused = false;

		GameObject parentVoice = GameObject.FindGameObjectWithTag ("Voice");
		voice = new Transform[parentVoice.transform.childCount];

		for (int i = 0; i < parentVoice.transform.childCount; i++) {

			voice [i] = parentVoice.transform.GetChild (i);

			voice [isPlaying].GetComponent<AudioSource> ().UnPause ();
		}
	}
}