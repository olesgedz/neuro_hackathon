using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainControler : MonoBehaviour {

	int i  = 0;
	public Animation referenceToAnimation;
 	public AnimationClip[] clips;
	// Use this for initialization
	 int _currClip = 0;
 	void OnAnimationComplete() //you could call this by adding an animation event at the end of all of your animations
 	{
     _currClip++;
     if(_currClip == clips.Length) return; //avoid out of scope exception
     referenceToAnimation.clip = clips[_currClip];
     referenceToAnimation.Play();
  	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	/*	if (Input.GetKeyDown(KeyCode.A))
		{
			print("aaaa\n");
			i = 1;
			_currClip++;
		} */
	}
}


 
