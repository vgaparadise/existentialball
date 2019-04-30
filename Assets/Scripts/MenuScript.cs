using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{
    public Button B;
    public Button A;
    public Button DEBUG_START;
    public string force_level_load;
    // Start is called before the first frame update
    void Start()
    {
        this.DEBUG_START = DEBUG_START;
        this.B = B;
        this.A = A;
        B.onClick.AddListener(BOnClick);
        A.onClick.AddListener(AOnClick);
        DEBUG_START.onClick.AddListener(DOnClick);
    }
    void DOnClick()
    {
        GameManager.StartGame(force_level_load);
    }


    void BOnClick()
    {
        GameManager.StartGame("B1");
    }

    void AOnClick()
    {
        GameManager.StartGame("A1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
