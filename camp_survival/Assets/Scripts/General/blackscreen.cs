using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackscreen : MonoBehaviour {

	public int beginning;
	public int end;
	public CanvasGroup panel;

	private bool woop = false;
	private bool weep = false;

	void Start () {

		StartCoroutine (Beginn ());
	}

	void Update() {

		if (woop == true) {

			panel = GetComponent<CanvasGroup> ();
			panel.alpha = panel.alpha + 0.02f;
		}

		if (weep == true) {

			panel = GetComponent<CanvasGroup> ();
			panel.alpha = panel.alpha - 0.02f;
		}
	}

	IEnumerator Beginn() {

		yield return new WaitForSeconds (beginning);
		woop = true;
		print ("yo");
		yield return new WaitForSeconds (end);
		print ("Yee");
		woop = false;
		weep = true;
	}
}
