using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modulation : MonoBehaviour
{
	AudioSource audio;
	float volume;

	void Start()
	{
		//Initiate the Slider value to half way
		volume = 0.1f;
		//Fetch the AudioSource from the GameObject
		audio = GetComponent<AudioSource>();
		//Play the AudioClip attached to the AudioSource on startup
		audio.Play();
	}

	void Update()
	{
		if (volume <= 1f) {

			volume = volume + 0.001f;
			audio.volume = volume;
		}
	}
}