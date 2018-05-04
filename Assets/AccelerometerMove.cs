using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerMove : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float temp = Input.acceleration.x;
        //Debug.Log(temp);
       // transform.Translate(temp * speed * Time.deltaTime, 0, 0);
       // transform.Translate(Input.acceleration.x * Time.smoothDeltaTime * 10, 0, 0);

   //     transform.Translate(new Vector2(Input.acceleration.x, 0) * Time.deltaTime * 10f);
        transform.Translate(new Vector3(Input.acceleration.x * 10f, 0, speed) * Time.deltaTime);
    }
}
