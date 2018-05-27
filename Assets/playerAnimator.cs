using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimator : MonoBehaviour {

    Animator anim;
    public bool startRunning;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	//	if (startRunning)
      //  {
        //    anim.Play("running");
       // }
	}
}
