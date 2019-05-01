using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/***************************************************
 * 
 * NOTE: Someday, this script probably will be depracated or non-static
 * right now, it handles only the changing of the level logic
 * 
 * 
 * 
 */
public class GameManager : MonoBehaviour
{

    
    public static string current_level = "menu";
    //these are the global variables to remember what the next level of the player in either the A or B.
    public static int next_A = 1;
    public static int next_B = 1;
    // Start is called by the main menu
    public static void StartGame(string level_start)
    {
        current_level = level_start;
        Application.LoadLevel(current_level);
    }

    public static void GoalReached(bool isAGoal)
    {
        //set the past influence equal to what it is now since the player successfully completed the level
        //influence_past = influence;
        if (current_level.Contains("A")) //if we just completed an A, go a++
            next_A++;
        else if (current_level.Contains("B")) //if we just completed a b
        {
            next_B++;
        }


        if (isAGoal)
        {
            current_level = "A" + next_A;
            

        }
        else
        {

            current_level = "B" + next_B;
            
        }
        Application.LoadLevel(current_level);
    }
    //THIS IS BROKEN
  
    //THIS SHOULD BE DEPRACATED? 
    /*
    public static void Reset()
    {
        //rollback the influence to what it was before
        influence = influence_past;
        Debug.Log("Influence now: " + influence);
        Application.LoadLevel(current_level);
        
    }
    */

}
