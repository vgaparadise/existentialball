using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {
    public float ASpeed = 900.0f;
    public float AMass = 5.0f;
    public float AFriction = 0.5f;
    public float AMaxVelocity = 30.0f;
    public float BSpeed = 150.0f;
    public float BMass = 0.05f;
    public float BFriction = 1.2f;
    
    private float playerSpeed;
    private float playerMass;
    private float playerFriction;
	// Use this for initialization
	void Start () {
        playerSpeed = Math.Min(ASpeed, BSpeed) + (GameManager.influence * Math.Abs(ASpeed - BSpeed));
        playerMass = Math.Min(AMass, BMass) + (GameManager.influence * Math.Abs(AMass - BMass));
        playerFriction = Math.Min(AFriction, BFriction) + ((1 - GameManager.influence) * Math.Abs(AFriction - BFriction));

        Rigidbody body = GetComponent<Rigidbody>();
		body.mass = playerMass;
        body.maxAngularVelocity += GameManager.influence * AMaxVelocity;

        Collider coll = GetComponent<Collider>();
        coll.material.dynamicFriction = playerFriction;
        coll.material.staticFriction = playerFriction;
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
