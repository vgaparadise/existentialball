using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelText : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("HideCanvas", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool HideCanvas() // the ide lies, this is obv used above
    {
        canvas.SetActive(false);
        return true;
    }
}
