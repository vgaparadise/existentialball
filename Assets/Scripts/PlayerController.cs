using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {
    public static PlayerController PLAYER;
    public float influence = 0.5f;
    public float ASpeed = 900.0f;
    public float AMass = 5.0f;
    public float AFriction = 0.5f;
    public float AMaxVelocity = 30.0f;
    public float BSpeed = 150.0f;
    public float BMass = 0.05f;
    public float BFriction = 1.2f;
    
    public float playerSpeed;
    private float playerMass;
    private float playerFriction;
	// Use this for initialization
	void Start () {
        playerSpeed = Math.Min(ASpeed, BSpeed) + (influence * Math.Abs(ASpeed - BSpeed));
        playerMass = Math.Min(AMass, BMass) + (influence * Math.Abs(AMass - BMass));
        playerFriction = Math.Min(AFriction, BFriction) + ((1 - influence) * Math.Abs(AFriction - BFriction));

        Rigidbody body = GetComponent<Rigidbody>();
		body.mass = playerMass;
        body.maxAngularVelocity += influence * AMaxVelocity;

        Collider coll = GetComponent<Collider>();
        coll.material.dynamicFriction = playerFriction;
        coll.material.staticFriction = playerFriction;
        DontDestroyOnLoad(this.gameObject);
        PLAYER = this;
    }
	
	// Update is called once per frame
	void Update () {
        //Get both the axis of control and put them in a vector
        var orig_direction = new Vector3(Input.GetAxis("Vertical"), 0f, -Input.GetAxis("Horizontal"));
        //grab hold of the body
        Rigidbody body = GetComponent<Rigidbody>();
        //make the movement in terms of the camera
        Vector3 relativeMovement = Camera.main.transform.TransformDirection(orig_direction);
        // relativeMovement.y = relativeMovement.x;
        // relativeMovement.x = relativeMovement.z;
        // relativeMovement.z = relativeMovement.y;
        relativeMovement.y = 0f;
        /*******************************/
        //OLD MOVEMENT CODE THAT I CANNOT GET TO WORK WITH RELATIVE CAMERA 
        body.AddTorque(relativeMovement * playerSpeed * Time.deltaTime);
        /*******************************/
        //Multiply speed times time to be framerate independent
        //body.AddForce(relativeMovement * playerSpeed * Time.deltaTime);
        print("orig: " + orig_direction + " rm: " + relativeMovement);
    }
    public void PowerupGet(float powerup)
    {
        influence += powerup;
        Debug.Log("Influence now: " + influence);
    }
}
