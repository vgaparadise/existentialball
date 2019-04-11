using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float playerSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Get both the axis of control 
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        //grab hold of the body
        Rigidbody body = GetComponent<Rigidbody>();
        //Multiply speed times time to be framerate independent
        body.AddTorque(new Vector3(xAxis, 0, yAxis) * playerSpeed * Time.deltaTime);


	}
}
