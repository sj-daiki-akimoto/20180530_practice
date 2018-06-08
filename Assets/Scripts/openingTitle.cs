using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class openingTitle : MonoBehaviour {

	Button startBtn;
	GameObject parentObj;

	// Use this for initialization
	void Start () {
		startBtn = GameObject.FindWithTag("startBtn").GetComponent<Button>();
		startBtn.onClick.AddListener(startBtnClicked);
	}

	void startBtnClicked() {
		SceneManager.LoadScene("Main");
		// Debug.Log("btn clicked");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
