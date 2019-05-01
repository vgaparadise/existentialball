using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutmenuScript : MonoBehaviour
{
    GameObject player;
    public Button back;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        this.back = back;
        back.onClick.AddListener(backOnClick);
    }

    void backOnClick()
    {
        //destroy player
        Destroy(player);
        Application.LoadLevel("MainMenu");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
