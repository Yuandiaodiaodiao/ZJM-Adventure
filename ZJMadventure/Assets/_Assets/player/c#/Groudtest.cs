using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groudtest : MonoBehaviour {
    public bool is_onground;
	// Use this for initialization
	void Start () {
        is_onground = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            is_onground = true;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ground")
        {
            is_onground = false;
        }
    }
}
