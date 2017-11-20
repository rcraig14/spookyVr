using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {
	// Use this for initialization
	public string doorState;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		changeDoorState (doorState);

	}

	/* changeDoor(string state)
	 * Called every update.
	 * In order to change this the public variable doorState needs to be changed
	 */
	void changeDoorState(string state){
		float rotation = 0;
		int speed = 0;
		string audioClip = "";
		switch (state) {
		case "open":
			rotation = 90;
			speed = 5;
			audioClip = "open";
			break;
		case "close":
			rotation = 0;
			speed = 5;
			audioClip = "open";
			break;
		case "slam":
			rotation = 0;
			speed = 15;
			audioClip = "slam";
			break;

		case "slowOpen":
			rotation = 90;
			speed = 1;
			audioClip = "slowOpen";
			break;
		}
		doorRotation (rotation, speed);
	}

	void doorRotation(float yRotation, int speed){
		var target = Quaternion.Euler (0, yRotation, 0);
		if (Quaternion.Angle (transform.localRotation, target) > 1) {
			transform.localRotation = Quaternion.RotateTowards (transform.localRotation, target, speed);
		} 
	}

	void closeDoor(){
		//var target = Quaternion.Euler (0, 0, 0);
		//transform.localRotation = Quaternion.Slerp (transform.localRotation, TargetJoint2D, Time.deltaTime * 2);
	}


}
