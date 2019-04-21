using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //get the player and bring them in the level
        this.player = GameObject.Find("Player");
        Respawn();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {
        //make it so the player spawns with 0 velocity / angular velocity
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.transform.position = this.transform.position;
    }
}
