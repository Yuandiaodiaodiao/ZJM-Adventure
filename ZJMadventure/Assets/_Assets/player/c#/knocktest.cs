using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knocktest : MonoBehaviour {
	public bool onknock;
	// Use this for initialization
	void Start () {
		onknock = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "ground") {
			onknock = true;
		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "ground") {
			onknock = false;
		
		}
	}
}
