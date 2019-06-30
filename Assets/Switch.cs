using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Switch : MonoBehaviour {

	// Use this for initialization
	public Camera camera1;
	public Camera camera2;
	public Button button;
	void Start () {
		
	}

	public void Swift ()
	{
		camera1.enabled = !camera1.enabled;
		camera2.enabled = !camera2.enabled;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
