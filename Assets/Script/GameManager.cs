using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    public float Timer;
    [SerializeField] public float TimeCount;
    public bool isCount=false;

    public bool Eis2;
    public bool Eis4;
    public bool Eis8;
    public bool Eis16;
    public bool Eis32;

    public bool E1is2;
    public bool E1is4;
    public bool E1is8;
    public bool E1is16;
    public bool E1is32;

    int randomnum1;
    int randomnum2;
    public float fireTimer;
    [SerializeField] public float fireTimeCount;
    public bool fireisCount = false;
    public bool onetime;




    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        BlockFireShow1(99);

        Timer = 5;
        TimeCount = Timer;
        fireTimer = 1;
        fireTimeCount = fireTimer;
        
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

        if (!fireisCount)
        {
            if (onetime == false)
            {
                onetime = true;
                randomnum1 = randomnum2;
                randomnum2 = Random.Range(0, 99);
            }

            fireTimeCount = fireTimeCount - Time.deltaTime;
                if (fireTimeCount <= 0)
                {


                    fireisCount = true;
                    onetime = false;
                    fireTimeCount = fireTimer;

                }
            
        }

        BlockFireShow1(randomnum1);
        BlockFireShow2(randomnum2);
        //Debug.Log(randomnum2);
    }

    public void SwitchNumber()
    {
        int wait1 = randomnum1;
        int wait2 = randomnum2;

        randomnum1 = wait2;
        randomnum2 = wait1;



    }

    public void BlockFireShow1(int randomInt)
    {
        if (randomInt >= 40)
        {
            Eis2 = true; Eis4 = false; Eis8 = false; Eis16 = false;
        }
        else if (randomInt >= 20)
        {
            Eis2 = false; Eis4 = true; Eis8 = false; Eis16 = false;
        }

        else if (randomInt >= 5)
        {
            Eis2 = false; Eis4 = false; Eis8 = true; Eis16 = false;

        }
        else
        {
            Eis2 = false; Eis4 = false; Eis8 = false; Eis16 = true;
        }

    }
    public void BlockFireShow2(int randomInt2)
    {
        if (randomInt2 >= 40)
        {
            E1is2 = true; E1is4 = false; E1is8 = false; E1is16 = false;
        }
        else if (randomInt2 >= 20)
        {
            E1is2 = false; E1is4 = true; E1is8 = false; E1is16 = false;
        }

        else if (randomInt2 >= 5)
        {
            E1is2 = false; E1is4 = false; E1is8 = true; E1is16 = false;

        }
        else
        {
            E1is2 = false; E1is4 = false; E1is8 = false; E1is16 = true;
        }

    }
}
