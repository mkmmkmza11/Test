using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public float Timer;
    [SerializeField] public float TimeCount;
    public bool isCount=false;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        
        Timer = 5;
        TimeCount = Timer;
    }

    private void Update()
    {
        if (!isCount)
        {

            TimeCount = TimeCount - Time.deltaTime;
            if (TimeCount <= 0)
            {

                isCount = true;
                TimeCount = Timer;


            }
        }
        

    }
    


}
