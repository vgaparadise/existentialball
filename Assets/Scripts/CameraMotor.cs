using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour {
    //what the camera will be focused on
    public GameObject target;
    public Vector3 distanceFromPlayer;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = target.transform.position + distanceFromPlayer;
        //point the camera at the player
        transform.LookAt(target.transform.position);

	}
}
