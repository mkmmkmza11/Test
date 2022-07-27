using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCountEndless : MonoBehaviour
{
    public static TimeCountEndless instance;
    //public int minute, Sec;
    float  SecCount;
    public TextMeshProUGUI CloakGUI;
    public int SecCountint, minuteCount;
    public int Score;
    public TextMeshProUGUI[] ScoreGui;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //minuteCount = minute;
        //SecCount = Sec;
    }

    // Update is called once per frame
    void Update()
    {
        SecCountint = (int)SecCount;
        CloakGUI.text = minuteCount.ToString() + " : " + SecCountint.ToString();
        ScoreGui[0].text = Score.ToString();
        ScoreGui[1].text = Score.ToString();


        TimeCount();
    }

    public void TimeCount()
    {
        if (SecCount <= 60)
        {
            SecCount = SecCount + Time.deltaTime;
        }

        if (SecCount >= 60)
        {
            
            
                minuteCount = minuteCount + 1;
                SecCount = 0;
            


        }






    }


    public void SetTime()
    {

        if (GameManager.instance.GameLose==true)
        {
            PlayerPrefs.SetInt("Minute", minuteCount);
            PlayerPrefs.SetInt("Sec", SecCountint);
            if (PlayerPrefs.GetInt("HighSec") <= SecCountint)
            {
                if (PlayerPrefs.GetInt("HighMinute") <= minuteCount)
                {
                    PlayerPrefs.SetInt("HighMinute", minuteCount);
                    PlayerPrefs.SetInt("HighSec", SecCountint);
                }
            }
        }
    }
    public void SetScore()
    {
        if (GameManager.instance.GameLose == true)
        {
            PlayerPrefs.SetInt("Score", Score);
            if (PlayerPrefs.GetInt("HighScore") <= Score)
            {
                PlayerPrefs.SetInt("HighScore", Score);
            }
        }
    }

    public void GetScore(int GetScore)
    {
        Score = Score + GetScore;
    }
}
