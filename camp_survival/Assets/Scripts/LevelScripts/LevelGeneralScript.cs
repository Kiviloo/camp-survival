using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelGeneralScript : MonoBehaviour {

	public void OnEnd() {

		SceneManager.LoadScene ("TestLevelEnde", LoadSceneMode.Single);
	}
}
