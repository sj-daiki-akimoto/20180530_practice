using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Main : MonoBehaviour {
    WebCamTexture webcamTexture;

    GameObject planeObj;
    Renderer renderer;

    public int width = 1080;
    public int height = 1920;
    public int fps = 30;

	// Use this for initialization
	void Start () {
        //
        // Webカメラを検出
        //
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length > 0) {
            //Debug.Log("Webカメラ検出");

            webcamTexture = new WebCamTexture(width, height, fps);
            planeObj = GameObject.Find("Plane");
            renderer = planeObj.GetComponent<Renderer>();
            renderer.material.mainTexture = webcamTexture;
            webcamTexture.Play();

        } else {
            Debug.LogError("Webカメラが検出できません");
        }

	}
	
	// Update is called once per frame
	void Update () {

	}
}
