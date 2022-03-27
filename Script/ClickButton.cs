using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F2) && pause == 0)
        {
            pause = 1;
        }
        else if (Input.GetKeyDown(KeyCode.F2) && pause == 1)
        {
            pause = 0;
        }

        if(pause == 1)
        {
            Time.timeScale = 0;
        }
        else if (pause == 0)
        {
            Time.timeScale = 1;
        }
    }
    int pause = 1;

       
    
}
