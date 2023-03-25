using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public float slowMotionTimeScale;
    private float startTimeScale;
    private float startFixedDeltaTime;
    public bool SlowMo = false;


    void Start()
    {
        startTimeScale = Time.timeScale;
        startFixedDeltaTime = Time.fixedDeltaTime;
    }
    
    void Update()
    {
        if (SlowMo)
        {
            StartSlowMotion();
        }

    }


    public void StartSlowMotion()
    {
        Time.timeScale = slowMotionTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime + slowMotionTimeScale;
    }

    public void StopSlowMotion()
    {
        Time.timeScale = startTimeScale;
        Time.fixedDeltaTime = startFixedDeltaTime;
    }
}
