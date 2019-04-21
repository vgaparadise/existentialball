using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneScript : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        //GameManager.Reset();
        var spawner_object = GameObject.Find("PlayerSpawner");
        var spawner_script = spawner_object.GetComponent<PlayerSpawn>();
        spawner_script.Respawn();
    }
}
