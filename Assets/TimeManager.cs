using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    float timeValue = 180;
    Text TimeText;
    public GameObject BlakcScreen;
    public GameObject ResetBtn;
    // Start is called before the first frame update
    void Start()
    {
        timeValue = 180;
        TimeText = GetComponent<Text>();
        TimeText.text = timeValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        TimeText.text = timeValue.ToString("F0");

        if (timeValue <= 0)
        {
            BlakcScreen.SetActive(true);
            ResetBtn.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
