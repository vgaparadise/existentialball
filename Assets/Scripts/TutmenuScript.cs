using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutmenuScript : MonoBehaviour
{
    public Button back;
    // Start is called before the first frame update
    void Start()
    {
        this.back = back;
        back.onClick.AddListener(backOnClick);
    }

    void backOnClick()
    {
        Application.LoadLevel("MainMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
