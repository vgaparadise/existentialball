using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    
    public static string current_level;
    //these are the global variables to remember what the next level of the player in either the A or B.
    public static int next_A = 1;
    public static int next_B = 1;
    public static float influence = 0.5f;
    public static float influence_this_level = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoalReached()
    {
        influence += influence_this_level;   
    }

    void Reset()
    {
        influence_this_level = 0;
        Application.LoadLevel(current_level);
    }

}
