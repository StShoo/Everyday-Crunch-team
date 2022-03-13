using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    public Text dayTimer;
    public float currentTime;
    
    
    void Start()
    {
        currentTime = 0;
    }
    
    void FixedUpdate()
    {
        DisplayTime(CountTime());
    }

    private float CountTime()
    {
        currentTime += Time.deltaTime;
        return currentTime;
    }
    
    private void DisplayTime(float currentTime)
    {
        
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        dayTimer.text = string.Format("{00:00}:{1:00}", minutes, seconds);

    }
}
