using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour
{
    public Button B;
    public Button A;
    // Start is called before the first frame update
    void Start()
    {
        this.B = B;
        this.A = A;
        B.onClick.AddListener(BOnClick);
        A.onClick.AddListener(AOnClick);
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
