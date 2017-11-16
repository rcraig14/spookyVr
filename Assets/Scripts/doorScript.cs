using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		openDoor ();
	}

	void openDoor(){
		var target = Quaternion.Euler (0, 90, 0);
		transform.localRotation = Quaternion.Slerp (transform.localRotation, target, Time.deltaTime * 2);
	}

	void closeDoor(){

	}
}
