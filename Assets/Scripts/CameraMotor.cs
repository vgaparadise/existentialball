using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://answers.unity.com/questions/600577/camera-rotation-around-player-while-following.html
public class CameraMotor : MonoBehaviour {
    //what the camera will be focused on
    public float turnSpeed = 10.0f;
    GameObject target;
    public Vector3 distanceFromPlayer;
    //public Rigidbody collider; 
    private Vector3 offset;
    //public Camera camera;
    // Use this for initialization
    void Start () {
        //find the player object
        target = GameObject.Find("Player");
        if (GameManager.current_level == "A3")
        {
            offset = new Vector3(4, 4, 4);
        } else
        {
            offset = new Vector3(4, 4, 4);
        }
    }
	
	// Update is called once per frame
	void Update () {
        //collider.MovePosition(camera.transform.position);
        //this.transform.position = 
        //target.transform.position + distanceFromPlayer;
        //point the camera at the player
        //transform.LookAt(target.transform.position);

    }
    void LateUpdate() 
    {
        if(!GameManager.paused)
        {
            var cam_in = Input.GetAxis("Mouse X");
            offset = Quaternion.AngleAxis(cam_in * turnSpeed, Vector3.up) * offset;
            transform.position = target.transform.position + offset;
            transform.LookAt(target.transform.position);
        }

    }
}
