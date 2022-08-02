using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCountLose : MonoBehaviour
{
   public int minute, Sec ;
    float minuteCount, SecCount;
    public TextMeshProUGUI CloakGUI;
    public int SecCountint;
    
    // Start is called before the first frame update
    void Start()
    {
        minuteCount = minute;
        SecCount = Sec;
    }

    // Update is called once per frame
    void Update()
    {
        SecCountint = (int)SecCount;
        CloakGUI.text = minuteCount.ToString() +" : " + SecCountint.ToString();
        LoseTime();
        TimeCount();
    }

    public void TimeCount()
    {
        if (SecCount >= 0)
        {
            SecCount = SecCount - Time.deltaTime;
        }

        if(SecCount <= 0)
        {
            if (minuteCount > 0)
            {
                minuteCount = minuteCount - 1;
                SecCount = 60;
            }
            
            
        }






    }


    public void LoseTime()
    {
        if(minuteCount <= 0&&SecCount<=0)
        {
            GameManager.instance.GameLose = true;
        }
    }

}
