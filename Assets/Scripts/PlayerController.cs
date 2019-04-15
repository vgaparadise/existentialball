﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {
    public float influence;
    public float ASpeed = 250.0f;
    public float AMass = 8.0f;
    public float AFriction = 0.8f;
    public float BSpeed = 120.0f;
    public float BMass = 0.05f;
    public float BFriction = 5.0f;
    
    private float playerSpeed;
    private float playerMass;
    private float playerFriction;
	// Use this for initialization
	void Start () {
        playerSpeed = Math.Min(ASpeed, BSpeed) + (influence * Math.Abs(ASpeed - BSpeed));
        playerMass = Math.Min(AMass, BMass) + (influence * Math.Abs(AMass - BMass));
        playerFriction = Math.Min(AFriction, BFriction) + ((1 - influence) * Math.Abs(AFriction - BFriction));

        Rigidbody body = GetComponent<Rigidbody>();
		body.mass = playerMass;

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