using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    public static int ScoreValue;
    Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        ScoreValue = 0;
        ScoreText.text = "$ " + ScoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "$ " + ScoreValue.ToString();
    }
}
