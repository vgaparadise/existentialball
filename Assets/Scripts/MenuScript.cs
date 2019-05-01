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
    public InputField inF;
    public string force_level_load;
    // Start is called before the first frame update
    void Start()
    {
        this.back = back;
        this.main_menu = main_menu;
        this.tutcan = tutcan;
        tutcan.SetActive(false);
        this.tut = tut;
        this.inF = inF;
        this.DEBUG_START = DEBUG_START;
        DEBUG_START.onClick.AddListener(DOnClick);
        tut.onClick.AddListener(tutOnClick);
        back.onClick.AddListener(backOnClick);
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
}
