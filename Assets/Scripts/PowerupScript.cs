using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour
{
    public float powerup_amount;
    public AudioSource audioData;
    void Start()
    {
        this.powerup_amount = powerup_amount;
    }
    void OnCollisionEnter(Collision col)
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        PlayerController.PLAYER.PowerupGet(powerup_amount);
        //Once the player got this powerup, remove it.
        Destroy(gameObject);
    }
}
