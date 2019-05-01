using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{
    public Button DEBUG_START;
    public string force_level_load;
    // Start is called before the first frame update
    void Start()
    {
        this.DEBUG_START = DEBUG_START;
        DEBUG_START.onClick.AddListener(DOnClick);
    }
    void DOnClick()
    {
        GameManager.StartGame(force_level_load);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
