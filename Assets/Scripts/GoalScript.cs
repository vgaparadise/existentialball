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
        //Load the next level based on which goal type the player chose
        string level_name;
        if(isAGoal)
        {
            level_name = "A" + GameManager.next_A;
            GameManager.next_A += 1;
        }
        else
        {
            level_name = "B" + GameManager.next_B;
            GameManager.next_B += 1;
        }
            
        Application.LoadLevel(level_name);
    }
}
