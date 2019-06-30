using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CrowdAnim : MonoBehaviour {

	public Animator anim;
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
		
		if (Mathf.Abs(1 - SampleApp.res) > 0.2)
		{
			anim.SetInteger("state",_currClip);
			if (_currClip == 5)
				_currClip = 0;
			else 
				_currClip++;
		}
	}
}
