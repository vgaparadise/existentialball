using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    //HACK: Disabled b/c it didn't work
    ////HACK: Prevents double pause menu instances due to donotdestroy onload
    //public void Awake()
    //{

    //    if (FindObjectsOfType(GetType()).Length > 1)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        this.gameObject.SetActive(false);
    }

    public void Restart()
    {
        Debug.Log("restart called");
        ResumeGame();
        GameManager.Reset();
        
    }

    public void GoToMenu()
    {
        Debug.Log("gotomenu called");
        ResumeGame();
        GameManager.ReturnToMenu();
    }

    public void ExitGame()
    {
        Debug.Log("called quit");
        Application.Quit();
    }

    public void ResumeGame()
    {
        //TODO: Fix duplicated code here and in playercontroller
        this.gameObject.SetActive(false);
        Time.timeScale = 1;
        GameManager.paused = false;
    }
}
