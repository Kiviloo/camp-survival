using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axt : MonoBehaviour {

	public static bool axtBool = false;
	public static int temp = 0;

	void Start() {

		if (temp == 0) {
			print ("Axt geht");
			axtBool = true;
			temp = 1;
		}
	}
}
