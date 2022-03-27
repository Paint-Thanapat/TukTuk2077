using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsCarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int speedX = 3, directionX = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime * speedX * directionX, 0, 0);
    }
}
