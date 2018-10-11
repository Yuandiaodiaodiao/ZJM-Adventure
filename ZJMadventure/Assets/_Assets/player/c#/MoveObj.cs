using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class MoveObj : MonoBehaviour {
	private bool ifjump; 
	public float jumpspeed;
	private Rigidbody2D rig2d; 
	public LayerMask walllayer;
	public float speed;
	private int jumptimes;
	private float movex;
	private int turns1;
	[SerializeField] private float knockg;
	[SerializeField] private float playerheight;
	// Use this for initialization
	void Start () {
		ifjump = false;
		rig2d = GetComponent<Rigidbody2D> ();
		jumptimes = 0;
		turns1 = 0;
	}
	
	// Update is called once per frame
	void Update () {
        //   Debug.Log(EditorUserBuildSettings.activeBuildTarget);
        //   Debug.Log(BuildTarget.WebGL);
        //  Debug.Log(BuildTarget.Android);
        //Debug.Log(BuildTarget.);
        bool onwebgl = false;
        if(onwebgl)
        {
            float movey= CrossPlatformInputManager.GetAxis("Vertical");
            Debug.Log(movey);
            if (movey > 0.5f && jumptimes <= 1) ifjump = true;
        }
        else 
		if (CrossPlatformInputManager.GetButtonDown("Jump")&&jumptimes<=1)
		{

			ifjump = true;
		}
	}
	void FixedUpdate(){
		movec ();



	}
	void movec(){
		
		Vector2 v = rig2d.velocity;
        if (ifground())
            jumptimes = 0;
		if (ifjump) {
            if(!ifground())
    			jumptimes++;
            ifjump = false;
            if(jumptimes <= 1)
    			v.y=jumpspeed;

		}
		movex=CrossPlatformInputManager.GetAxis("Horizontal");
		if ((movex > 0.1 || movex < -0.1))
		if (movex > 0)
			transform.localScale =new Vector3 (-1, 1, 1);
		else transform.localScale =new Vector3 (1, 1, 1);
			v.x = speed * movex;
		//rig2d.velocity = new Vector2 (speed*movex, rig2d.velocity.y);
		if (ifknock ()) {/*
			if (turns1 == 10) {
				turns1 = 0;
			} else {*/
				turns1++;
				//Debug.Log ("speed--");
				v.x = rig2d.velocity.x;
				//rig2d.velocity = new Vector2 (rig2d.velocity.x, rig2d.velocity.y - knockg);}
			}
        //
		rig2d.velocity = v;
	}

	bool ifknock(){
		return GetComponentInChildren<knocktest> ().onknock;
	}
	bool ifground(){
        /*	RaycastHit2D ray = Physics2D.Raycast (transform.position, -transform.up, playerheight, walllayer);
            Debug.DrawLine (transform.position, transform.position + new Vector3 (0f, -playerheight, 0f), Color.red);
            if (ray.collider != null)
                return true;
            return false;*/
        return GetComponentInChildren<Groudtest>().is_onground;
	}
}
