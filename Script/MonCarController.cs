using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonCarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int speedY = 3, directionY = -1;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Time.deltaTime * speedY * directionY, 0);
    }
}
