using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    bool stopWatchActive = false;
    public float currentTime;
    [SerializeField] UIManager uiManager;
    
    void Start()
    {
        currentTime = 60f;
    }

    void Update()
    {
        if (stopWatchActive == true && currentTime >= 0)
        {
            currentTime = currentTime - Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        uiManager.currentTimeText.text = time.ToString(@"mm\:ss");
    }

    public void StartStopwatch(bool timerStart)
    {
        stopWatchActive = timerStart;
    }

    public void ResetStopwatch()
    {
        currentTime = 60f;
    }
}
