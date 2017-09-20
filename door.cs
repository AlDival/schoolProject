using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	Animator door;


	// Use this for initialization
	void Start () {
		door = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		door.SetTrigger ("OpenDoor");
		
	}
	void OnTriggerExit(Collider other){
		door.enabled = true;
	}
	void pauseAnimationEvent(){
		door.enabled = false;
	}
}
