using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject tutcan;
    public Button DEBUG_START;
    public Button tut;
    public Button back;
    public Button exit;
    public InputField inF;
    public string force_level_load;
    // Start is called before the first frame update
    void Start()
    {
        tutcan.SetActive(false);
        //DEBUG_START.onClick.AddListener(DOnClick);
        tut.onClick.AddListener(tutOnClick);
        back.onClick.AddListener(backOnClick);
        exit.onClick.AddListener(ExitGameFromMainMenu);
        if (force_level_load != null && force_level_load != "")
        {
            GameManager.StartGame(force_level_load);
        }
    }
    void backOnClick()
    {
        tutcan.SetActive(false);
        main_menu.SetActive(true);
    }
    void tutOnClick()
    {
        main_menu.SetActive(false);
        tutcan.SetActive(true);
    }
    void DOnClick()
    {
        GameManager.StartGame(inF.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ExitGameFromMainMenu()
    {
        Application.Quit();
    }
}
