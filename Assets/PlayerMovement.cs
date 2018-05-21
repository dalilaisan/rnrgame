using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private CharacterController controller;
    public float speed = 8.0f;
    private bool isDead = false;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead) return;
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        controller.Move(Vector3.forward * Time.deltaTime * speed);
	}

    //Called whenever our player hits something
   // private void OnControllerColliderHit(ControllerColliderHit hit)
   // {
   //     if (hit.point.z > transform.position.z + controller.radius)
   //         Death();
  //  }

//    private void Death()
  //  {
    //    isDead = true;
   // }

    public void setSpeed(float modifier)
    {
        speed = 8.0f + modifier;
    }
}
