using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class MenuMain : MonoBehaviour {

	// Use this for initialization
	public Camera camera1;
 	public Camera camera2;
	public void Start () {
		camera1.enabled = true;
     	camera2.enabled = false;
	}
	public void Switch ()
	{
		camera1.enabled = !camera1.enabled;
		StartCoroutine (SwitchToVR());
		camera2.enabled = !camera2.enabled;
	}

	// Call via `StartCoroutine(SwitchToVR())` from your code. Or, use
	// `yield SwitchToVR()` if calling from inside another coroutine.
	IEnumerator SwitchToVR() {
		// Device names are lowercase, as returned by `XRSettings.supportedDevices`.
		String desiredDevice = "cardboard"; // Or "cardboard".

		// Some VR Devices do not support reloading when already active, see
		// https://docs.unity3d.com/ScriptReference/XR.XRSettings.LoadDeviceByName.html
		if (String.Compare(UnityEngine.XR.XRSettings.loadedDeviceName, desiredDevice, true) != 0) {
			UnityEngine.XR.XRSettings.LoadDeviceByName(desiredDevice);

			// Must wait one frame after calling `XRSettings.LoadDeviceByName()`.
			yield return null;
		}
		// Now it's ok to enable VR mode.
		UnityEngine.XR.XRSettings.enabled = true;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
		{
			Switch ();
		}
	}
}
