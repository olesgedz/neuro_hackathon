using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CrowdAnim : MonoBehaviour {

	public Animator anim;
	public Animation referenceToAnimation;
 	public AnimationClip[] clips;
	AudioSource audioData;
	public Button full;
	public Button error;
	int i = 0;
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
		audioData = GetComponent<AudioSource>();
		full.onClick.AddListener(TaskOnClick);
		error.onClick.AddListener(TaskErr);
	}
	
	// Update is called once per frame
	void TaskErr()
	{
		i = -15;
	}

	void TaskOnClick()
	{
		i = 15;
	}

	public void Sad()
	{
		//anim.SetInteger ("state", _currClip);
		//audioData.Play (0);
		/*if (_currClip == 5)
				_currClip = 0;
			else
				_currClip == 11;*/
		anim.SetInteger("state",1);
		print ("sad");
	}

	public void Happy()
	{
		anim.SetInteger("state",2);
		print ("happy");

	}


	void Update () {
		
		/*if (i == 15)				//Mathf.Abs (1 - SampleApp.res) > 0.2)
		{
			Sad ();
		} else {
			anim.SetInteger("state",11);;
		}*/
	}
}
