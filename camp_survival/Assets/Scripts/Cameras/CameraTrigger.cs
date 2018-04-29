using System.Collections;
using System.Collections.Generic;
using UnityEngine;

															//Nichts Verändern!
public class CameraTrigger : MonoBehaviour {


	void LateUpdate () {

		FindObjectOfType<Cameras> ().FollowingCam (FindObjectOfType<Cameras>().camera, FindObjectOfType<Cameras>().ziel);
	}
}
