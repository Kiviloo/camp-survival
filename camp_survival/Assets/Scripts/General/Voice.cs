using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour {

	public AudioClip[] voiceOver;
	private AudioClip[] voices;
	public float[] seconds;
	private AudioSource audio;

	void Start() {

		StartCoroutine(PlaySound ());
	}

	IEnumerator PlaySound() {

		voices = new AudioClip[voiceOver.Length];

		AudioSource audio = GameObject.FindGameObjectWithTag ("Voice").GetComponent<AudioSource> ();

		for (int i = 0; i <= voiceOver.Length - 1; i++) {

			voices [i] = voiceOver [i];
		}

		for (int i = 0; i <= voiceOver.Length - 1; i++) {

			audio.clip = voices [i];
			audio.Play ();

			if (i > seconds.Length - 1) {
				yield return new WaitForSeconds (audio.clip.length);
			} else {
				yield return new WaitForSeconds (audio.clip.length + seconds [i]);
			}
		}
	}
}