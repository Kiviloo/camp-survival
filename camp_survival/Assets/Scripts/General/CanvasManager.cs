using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;
															//Nichts verändern!

public class CanvasManager : MonoBehaviour {

	public Canvas canvas1;
	public PlayableDirector timeline;
	double time;
	double timeTimeLine;


	void Start () {

		timeTimeLine = timeline.duration;

		canvas1.enabled = false;
	}	


	void Update () {

		time += Time.deltaTime;

		if (time >= timeTimeLine) {
			canvas1.enabled = true;
		}
	}
}