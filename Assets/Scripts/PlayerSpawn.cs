using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject player;
    //the music that will be played 
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        //get the player and bring them in the level
        this.player = GameObject.Find("Player");
        //play the music
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        //show the text

        Respawn();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        Debug.Log("respawning player");
        //make it so the player spawns with 0 velocity / angular velocity
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        //0 out their speed
        //player.GetComponent<PlayerController>().playerSpeed = 0f;
        player.transform.position = this.transform.position;
    }
}
