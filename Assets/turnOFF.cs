﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOFF : MonoBehaviour {

	// Use this for initialization
	void Start () {
     //   GetComponent(MeshRenderer).enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
