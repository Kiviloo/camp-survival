using System.Collections;
using System.Collections.Generic;
using UnityEngine;

													//Nichts Verändern!
[System.Serializable]
public class Cameras : MonoBehaviour {


	public List<Camera> camera;
	public List<GameObject> ziel;
	private Vector3 offset = new Vector3(0,0,-10f);


	public void FollowingCam (List<Camera> cam, List<GameObject> ziel) {

		for (int i = 0; i <= cam.Count - 1; i++) {
			cam [i].transform.position = ziel [i].transform.position + offset;
		}
	}
}