using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioForplayer : MonoBehaviour
{
    public AudioClip HitClip;
    public AudioSource HitSource;
    // Start is called before the first frame update
    void Start()
    {
        HitSource.clip = HitClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            HitSource.Play();
        }
    }
}
