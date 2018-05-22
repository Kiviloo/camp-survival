using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public bool activate;
	public Text timerText;
	public int howLong;
	private float startTime;

	private double time;

	void Start () {

		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		if (activate == true && GameObject.Find ("Canvas").activeSelf == true) {

			float t = Time.time - startTime;
			int check = ((int)((howLong - (t % 60)) + 1));
			string output = ((int)((howLong - (t % 60))) + 1).ToString ();
			timerText.text = output;

			if (check == 0) {

				timerText.enabled = false;
			}

		} else if (activate == false) {

			GameObject.Find ("TextTimer").GetComponent<Text>().enabled = false;
		} else {

			timerText.enabled = false;
		}
			
	}
}
