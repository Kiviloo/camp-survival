using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTime : MonoBehaviour {

	void Start () {

		StartCoroutine (Beginn ());
		}

	IEnumerator Beginn() {

		yield return new WaitForSeconds (6);
		Time.timeScale = 0.1f;
		yield return new WaitForSeconds (2);
		Time.timeScale = 1f;
	}
}
