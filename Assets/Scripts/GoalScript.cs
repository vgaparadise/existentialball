using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    //You set the goal type in the unity editor when you add the entity (goal) to the level
    public bool isAGoal;
    // Start is called before the first frame update
    void Start()
    {
        this.isAGoal = isAGoal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        GameManager.GoalReached(isAGoal);
    }
}
