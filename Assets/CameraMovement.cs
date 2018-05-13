using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    private Transform lookAt;
    private Vector3 startOffset;
    private float transition = 0.0f;
   // private float animationDuration = 2.0f;
    public float speed = 5.0f;


	// Use this for initialization
	void Start () {
        lookAt = GameObject.FindGameObjectWithTag ("Player").transform;
        startOffset = transform.position - lookAt.position;
	}   
	
	// Update is called once per frame
	void Update () {

      //  if (Time.time < animationDuration)
      //  {
      //      ControllerColliderHit.Move(Vector3.forward * speed * Time.deltaTime);
      //      return;
      //  }

        transform.position = lookAt.position + startOffset;


        //Animation at the beginning of the game
       // transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
       // transition += Time.deltaTime * 1 / animationDuration;
	}
}
