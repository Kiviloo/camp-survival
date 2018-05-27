using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Transparenz : MonoBehaviour {

	public CanvasGroup panel;
	private float value = 1f;

	// Update is called once per frame
	void Update () {

		panel = GetComponent<CanvasGroup> ();
		panel.alpha = panel.alpha - 0.001f;
	}
}
