using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    //HACK: Prevents double pause menu instances due to donotdestroy onload
    public void Awake()
    {

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        this.gameObject.SetActive(false);
    }

    public void Restart()
    {
        ResumeGame();
        GameManager.Reset();
        
    }

    public void GoToMenu()
    {
        ResumeGame();
        GameManager.ReturnToMenu();
    }

    public void ExitGame()
    {
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
