using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGandParallex : MonoBehaviour {

	private GameObject parentBG;
	private GameObject parentSky;
	private GameObject parentMountains;
	private GameObject parentClouds;
	private GameObject parentTrees;

	private RectTransform rectBG;
	private RectTransform rectSky;
	private RectTransform rectMountains;
	private RectTransform rectClouds;
	private RectTransform rectTrees;

	private Transform[] bg;
	private Transform[] sky;
	private Transform[] mountains;
	private Transform[] clouds;
	private Transform[] trees;

	float widthBG;
	float widthSky;
	float widthMountains;
	float widthClouds;
	float widthTrees;

	private bool bgBool = true;
	private bool treesBool = true;
	private bool cloudsBool = true;
	private bool mountainsBool = true;
	private bool skyBool = true;

	public GameObject objectBG;
	public GameObject objectSky;
	public GameObject objectClouds;
	public GameObject objectMountains;
	public GameObject objectTrees;

	private float parallaxSkySpeed = 0.9f;
	private float parallaxMountainsSpeed = 0.3f;
	private float parallaxCloudsSpeed = 0.8f;
	private float parallaxTreesSpeed = -0.5f;

	private GameObject[] cameras;
	private float cameraPositionX;
	private Transform cameraTransform;

	private int leftIndex;
	private int rightIndex;
	private int leftIndexS;
	private int rightIndexS;
	private int leftIndexM;
	private int rightIndexM;
	private int leftIndexT;
	private int rightIndexT;
	private int leftIndexC;
	private int rightIndexC;


	private float area = 30;

	void Start () {

		cameras = GameObject.FindGameObjectsWithTag ("Cameras");

		if (objectBG == null || objectSky == null || objectClouds == null || objectMountains == null || objectTrees == null) {

			if (objectBG == null) {

				bgBool = false;
				objectBG = GameObject.Find ("_defaultObject");
			}

			if (objectTrees == null) {

				treesBool = false;
				objectTrees = GameObject.Find ("_defaultObject");
			}

			if (objectSky == null) {

				skyBool = false;
				objectSky = GameObject.Find ("_defaultObject");
			}

			if (objectClouds == null) {

				cloudsBool = false;
				objectClouds = GameObject.Find ("_defaultObject");
			}

			if (objectMountains == null) {

				mountainsBool = false;
				objectMountains = GameObject.Find ("_defaultObject");
			}
		}

		GameObject parentBG = GameObject.FindGameObjectWithTag ("BG");
		GameObject parentSky = GameObject.FindGameObjectWithTag ("Sky");
		GameObject parentMountains = GameObject.FindGameObjectWithTag ("Mountains");
		GameObject parentTrees = GameObject.FindGameObjectWithTag ("Trees");
		GameObject parentClouds = GameObject.FindGameObjectWithTag ("Clouds");
		GameObject parentDefault = GameObject.FindGameObjectWithTag ("_defaultObject");

		RectTransform rectBG = objectBG.GetComponent<RectTransform>();
		RectTransform rectSky = objectSky.GetComponent<RectTransform>();
		RectTransform rectMountains = objectMountains.GetComponent<RectTransform>();
		RectTransform rectClouds = objectClouds.GetComponent<RectTransform>();
		RectTransform rectTrees = objectTrees.GetComponent<RectTransform>();

		widthBG = rectBG.rect.width;
		widthSky = rectSky.rect.width;
		widthMountains = rectMountains.rect.width;
		widthClouds = rectClouds.rect.width;
		widthTrees = rectTrees.rect.width;

		bg = new Transform[parentBG.transform.childCount];
		sky = new Transform[parentSky.transform.childCount];
		mountains = new Transform[parentMountains.transform.childCount];
		clouds = new Transform[parentClouds.transform.childCount];
		trees = new Transform[parentTrees.transform.childCount];

		for (int i = 0; i < parentBG.transform.childCount; i++) {

			bg [i] = parentBG.transform.GetChild (i);
		}

		for (int i = 0; i < parentSky.transform.childCount; i++) {

			sky [i] = parentSky.transform.GetChild (i);
		}

		for (int i = 0; i < parentMountains.transform.childCount; i++) {

			mountains [i] = parentMountains.transform.GetChild (i);
		}

		for (int i = 0; i < parentClouds.transform.childCount; i++) {

			clouds [i] = parentClouds.transform.GetChild (i);
		}

		for (int i = 0; i < parentTrees.transform.childCount; i++) {

			trees [i] = parentTrees.transform.GetChild (i);
		}

		if (bgBool == false) {

			bg = new Transform[parentDefault.transform.childCount];

			for (int i = 0; i < parentDefault.transform.childCount; i++) {

				bg [i] = parentDefault.transform.GetChild (i);
			}
		}

		if (bgBool == false) {

			bg = new Transform[parentDefault.transform.childCount];

			for (int i = 0; i < parentDefault.transform.childCount; i++) {

				bg [i] = parentDefault.transform.GetChild (i);
			}
		}

		if (skyBool == false) {

			sky = new Transform[parentDefault.transform.childCount];

			for (int i = 0; i < parentDefault.transform.childCount; i++) {

				sky [i] = parentDefault.transform.GetChild (i);
			}
		}

		if (mountainsBool == false) {

			mountains = new Transform[parentDefault.transform.childCount];

			for (int i = 0; i < parentDefault.transform.childCount; i++) {

				mountains [i] = parentDefault.transform.GetChild (i);
			}
		}


		if (cloudsBool == false) {

			clouds = new Transform[parentDefault.transform.childCount];

			for (int i = 0; i < parentDefault.transform.childCount; i++) {

				clouds [i] = parentDefault.transform.GetChild (i);
			}
		}

		if (treesBool == false) {

			trees = new Transform[parentDefault.transform.childCount];

			for (int i = 0; i < parentDefault.transform.childCount; i++) {

				trees [i] = parentDefault.transform.GetChild (i);
			}
		}

		leftIndex = 0;
		rightIndex = bg.Length - 1;
		leftIndexM = 0;
		rightIndexM = mountains.Length - 1;
		leftIndexS = 0;
		rightIndexS = sky.Length - 1;
		leftIndexT = 0;
		rightIndexT = trees.Length - 1;
		leftIndexC = 0;
		rightIndexC = clouds.Length - 1;

	}

	void LeftC() {

		if (cloudsBool == true) {

			Vector3 cloudsHeight = new Vector3(0, clouds[leftIndexC].position.y, 0);
			clouds [rightIndexC].position = Vector3.right * (clouds [leftIndexC].position.x - widthClouds) + cloudsHeight;
		}

		leftIndexC = rightIndexC;
		rightIndexC--;

		if(rightIndexC < 0) {
			rightIndexC = clouds.Length-1;
		}
	}

	void LeftS() {


		if (skyBool == true) {

			Vector3 skyHeight = new Vector3(0, sky[leftIndex].position.y, 0);
			sky [rightIndex].position = Vector3.right * (sky [leftIndex].position.x - widthSky) + skyHeight;
		}

		leftIndexS = rightIndexS;
		rightIndexS--;

		if(rightIndexS < 0) {
			rightIndexS = sky.Length-1;
		}
	}

	void LeftM() {

		if (mountainsBool == true) {

			Vector3 mountainsHeight = new Vector3(0, mountains[leftIndex].position.y, 0);
			mountains [rightIndex].position = Vector3.right * (mountains [leftIndex].position.x - widthMountains) + mountainsHeight;
		}

		leftIndexM = rightIndexM;
		rightIndexM--;

		if(rightIndexM < 0) {
			rightIndexM = mountains.Length-1;
		}
	}

	void LeftT() {

		if (treesBool == true) {

			Vector3 treesHeight = new Vector3(0, trees[leftIndexT].position.y, 0);
			trees [rightIndexT].position = Vector3.right * (trees [leftIndexT].position.x - widthTrees) + treesHeight;
		}

		leftIndexT = rightIndexT;
		rightIndexT--;

		if(rightIndexT < 0) {
			rightIndexT = trees.Length-1;
		}
	}
		
	void Left() {

		if (bgBool == true) {

			Vector3 bgHeight = new Vector3(0, bg[leftIndex].position.y, 0);
			bg [rightIndex].position = Vector3.right * (bg [leftIndex].position.x - widthBG) + bgHeight;
		}

		leftIndex = rightIndex;
		rightIndex--;

		if(rightIndex < 0) {
			rightIndex = bg.Length-1;
		}
	}


	void RightC() {

		if (cloudsBool == true) {

			Vector3 cloudsHeight = new Vector3(0, clouds[leftIndexC].position.y, 0);
			clouds [leftIndexC].position = Vector3.right * (clouds [rightIndexC].position.x + widthClouds) + cloudsHeight;
		}

		rightIndexC = leftIndexC;
		leftIndexC++;

		if (leftIndexC == clouds.Length) {
			leftIndexC = 0;
		}
	}

	void RightS() {

		if (skyBool == true) {

			Vector3 skyHeight = new Vector3(0, sky[leftIndex].position.y, 0);
			sky [leftIndex].position = Vector3.right * (sky [rightIndex].position.x + widthSky) + skyHeight;
		}

		rightIndexS = leftIndexS;
		leftIndexS++;

		if (leftIndexS == sky.Length) {
			leftIndexS = 0;
		}
	}

	void RightM() {

		if (mountainsBool == true) {

			Vector3 mountainsHeight = new Vector3(0, mountains[leftIndex].position.y, 0);
			mountains [leftIndex].position = Vector3.right * (mountains [rightIndex].position.x + widthMountains) + mountainsHeight;
		}

		rightIndexM = leftIndexM;
		leftIndexM++;

		if (leftIndexM == mountains.Length) {
			leftIndexM = 0;
		}
	}

	void RightT() {

		if (treesBool == true) {

			Vector3 treesHeight = new Vector3(0, trees[leftIndexT].position.y, 0);
			trees [leftIndexT].position = Vector3.right * (trees [rightIndexT].position.x + widthTrees) + treesHeight;
		}

		rightIndexT = leftIndexT;
		leftIndexT++;

		if (leftIndexT == trees.Length) {
			leftIndexT = 0;
		}
	}

	void Right() {

		if (bgBool == true) {

			Vector3 bgHeight = new Vector3(0, bg[leftIndex].position.y, 0);
			bg [leftIndex].position = Vector3.right * (bg [rightIndex].position.x + widthBG) + bgHeight;
		}

		rightIndex = leftIndex;
		leftIndex++;

		if (leftIndex == bg.Length) {
			leftIndex = 0;
		}
	}


	void Update () {

		for (int i = 0; i < cameras.Length; i++) {

			if (cameras [i].GetComponent<Camera> ().enabled == true) {

				cameras [i].tag = "MainCamera";
			}
		}

		cameraTransform = GameObject.FindGameObjectWithTag ("MainCamera").transform;

		GameObject parentBG = GameObject.FindGameObjectWithTag ("BG");
		GameObject parentSky = GameObject.FindGameObjectWithTag ("Sky");
		GameObject parentMountains = GameObject.FindGameObjectWithTag ("Mountains");
		GameObject parentTrees = GameObject.FindGameObjectWithTag ("Trees");
		GameObject parentClouds = GameObject.FindGameObjectWithTag ("Clouds");

		float deltaX = cameraTransform.position.x - cameraPositionX;

		parentSky.transform.position += Vector3.right * (deltaX * parallaxSkySpeed);
		parentMountains.transform.position += Vector3.right * (deltaX * parallaxMountainsSpeed);
		parentTrees.transform.position += Vector3.right * (deltaX * parallaxTreesSpeed);
		parentClouds.transform.position += Vector3.right * (deltaX * parallaxCloudsSpeed);

		cameraPositionX = cameraTransform.position.x;

		if (cameraTransform.position.x < (bg [leftIndex].transform.position.x + area)) {

			Left ();
		}

		if (cameraTransform.position.x > (bg [rightIndex].transform.position.x - area)) {

			Right ();
		}

		if (cameraTransform.position.x < (clouds [leftIndexC].transform.position.x + area)) {

			LeftC ();
		}

		if (cameraTransform.position.x > (clouds [rightIndexC].transform.position.x - area)) {

			RightC ();
		}

		if (cameraTransform.position.x < (trees [leftIndexT].transform.position.x + area)) {

			LeftT ();
		}

		if (cameraTransform.position.x > (trees [rightIndexT].transform.position.x - area)) {

			RightT ();
		}

		if (cameraTransform.position.x < (sky [leftIndexS].transform.position.x + area)) {

			LeftS ();
		}

		if (cameraTransform.position.x > (sky [rightIndexS].transform.position.x - area)) {

			RightS ();
		}

		if (cameraTransform.position.x < (mountains [leftIndexM].transform.position.x + area)) {

			LeftM ();
		}

		if (cameraTransform.position.x > (mountains [rightIndexM].transform.position.x - area)) {

			RightM ();
		}
	}
}