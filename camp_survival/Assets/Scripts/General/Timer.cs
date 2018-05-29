using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	private int once = 0;
	public bool activate;
	public Text timerText;
	public int howLong;
	private float startTime;
	public static int check;

	private double time;

	void Start () {
		
		startTime = Time.time;
	}
	

	void LateUpdate () {

		if (activate == true && GameObject.Find ("CanvasEnde").GetComponent<Canvas>().enabled) {

			if (once == 0) {
				startTime = Time.time;
				once = 1;
				timerText.enabled = true;
			}

			float t = Time.time - startTime;
			check = ((int)((howLong - (t % 60)) + 1));
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
