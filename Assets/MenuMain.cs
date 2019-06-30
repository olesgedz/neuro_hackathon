﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMain : MonoBehaviour {

	// Use this for initialization
	public Camera camera1;
 	public Camera camera2;
	public void Start () {
		camera1.enabled = true;
     	camera2.enabled = false;
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
		{
			camera1.enabled = !camera1.enabled;
        	camera2.enabled = !camera2.enabled;
		}
	}
}
