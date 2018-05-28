using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject title;
	public GameObject ueber;
	public GameObject options;


	public void Start () {

		ueber.SetActive (false);
		options.SetActive(false);
		title.SetActive(true);
	}


	public void OnPlay ()  {

		SceneManager.LoadScene ("1.1", LoadSceneMode.Single);
	}


	public void OnUeber () {

		title.SetActive (false);
		ueber.SetActive (true);
	}


	public void OnOptions() {

		title.SetActive (false);
		options.SetActive (true);
	}


	public void OnQuit() {

		Application.Quit ();
	}


	public void OnBack() {

		ueber.SetActive (false);
		options.SetActive(false);
		title.SetActive(true);
	}
}
