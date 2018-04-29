using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralButtons : MonoBehaviour {


	public void OnDeath()  {

		SceneManager.LoadScene ("DeathScreen", LoadSceneMode.Single);
	}


	public void OnMainMenu() {

		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}
}
