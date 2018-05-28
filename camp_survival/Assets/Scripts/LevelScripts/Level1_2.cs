using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1_2 : MonoBehaviour {

		void Start () {

			StartCoroutine (HoldOn ());
		}

		IEnumerator HoldOn() {

			yield return new WaitForSeconds (9);
			SceneManager.LoadScene ("1.5", LoadSceneMode.Single);
		}
	}
