using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Reset()
    {
        int sIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene((sIndex));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
