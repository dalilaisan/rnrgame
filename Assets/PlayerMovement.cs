using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private CharacterController controller;
    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        controller.Move(Vector3.forward * Time.deltaTime * speed);
	}
}
