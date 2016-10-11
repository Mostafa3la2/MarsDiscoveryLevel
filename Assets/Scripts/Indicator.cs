using UnityEngine;
using System.Collections;

public class Indicator : MonoBehaviour {
	public GameObject mouse;
	public AudioSource beeb;
	// Copyright (c) 2010-2011 Sigma-Tau Productions (http://www.sigmatauproductions.com/).
	// This script is free to be used in both free and commercial projects as long as this
	// notice is retained.

	
	// The interval of time (in seconds) that the sound will be played.
	public float interval = 5f;
	
	// The sound itself.
	public AudioClip clipToPlay;
	
	// Private variables
	// A modifier that will prevent the script from running in the event of an error
	private bool disableScript = false;
	
	// The amount of time that has passed since the last initial playback of the sound.
	private float trackedTime = 0.0f;
	

	private float factor=1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!disableScript) {
			
			// Play the sound when the scene starts
		
			if(Distance()>25)factor=1;
			if(Distance()<10 && Distance()>=5)factor=2;
			if(Distance()<5 && Distance()>2)factor=3;
			if(Distance()<2)factor=6;
			// Increment the timer
			trackedTime += ((factor)*Time.deltaTime);
			
			// Check to see that the proper amount of time has passed
			if (trackedTime >= interval) {
				// Play the sound, reset the timer
				beeb.Play();
				trackedTime = 0.0f;
			}
		}
		//Debug.Log("distance from "+this.gameObject.name+Distance());

	}
	public float Distance(){
		return Mathf.Sqrt(Mathf.Pow(this.transform.position.x-mouse.transform.position.x,2)+Mathf.Pow(this.transform.position.y-mouse.transform.position.y,2)+Mathf.Pow(this.transform.position.z-mouse.transform.position.z,2));
	}
}
