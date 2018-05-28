using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modulationReverse : MonoBehaviour
{
	AudioSource audio;
	float volume;

	void Start()
	{

		volume = 1f;
		audio = GetComponent<AudioSource>();
		audio.Play();
	}

	void Update()
	{
		if (volume >= 0f) {

			volume = volume - 0.001f;
			audio.volume = volume;
		}
	}
}