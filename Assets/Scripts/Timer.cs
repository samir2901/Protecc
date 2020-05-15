using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public float startTime = 90f;
    public GameManager gameManager;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;    
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
            timerText.text = "TIME: " + (Math.Round(currentTime)).ToString();
        }else if(currentTime <= 0f)
        {
            gameManager.ShowWinScreen();
            //Debug.Log("Win");
        }
    }
}
