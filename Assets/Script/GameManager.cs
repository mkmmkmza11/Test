using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    
    [Header("SetTimeSpawn")]
    public float Timer;

    [Header("SetTimeFire")]
    public float fireTimer;

    [Header("View TimeSpawnCount")]
    [SerializeField] public float TimeCount;
    [SerializeField] public bool isCount = false;

    [Header("View FireTimeCount")]
    [SerializeField] public float fireTimeCount;
    [SerializeField] public bool fireisCount = false;
    [SerializeField] public bool onetime;

    [Header("Set Money")]
    public string MoneyText;
    public TextMeshProUGUI MoneyUi;
    public int Money;
    //public int MoneyEarn;


    [Header("GUI WIN LOSE")]
    public GameObject WinGUI;
    public GameObject LoseGUI;

    [Header("GUI Setting")]
    public GameObject SettingGUI;

    [Header("Show Block Don't Touch")]
    [SerializeField] public bool Eis2;
    [SerializeField] public bool Eis4;
    [SerializeField] public bool Eis8;
    [SerializeField] public bool Eis16;
    [SerializeField] public bool Eis32;

    [SerializeField] public bool E1is2;
    [SerializeField] public bool E1is4;
    [SerializeField] public bool E1is8;
    [SerializeField] public bool E1is16;
    [SerializeField] public bool E1is32;

    [SerializeField] int randomnum1;
    [SerializeField] int randomnum2;

    [SerializeField] public bool Take64;

    [SerializeField] public bool oneTimeICE;
    [SerializeField] public bool oneTimeFreeze;

    public bool GameLose;
    public bool TakeMoneyOneTime;

    public bool TimeCheck;

    [Header("AnimSetting")]
    [SerializeField] public bool TakeDamageAnim;
    [SerializeField] public bool DeadAnim;
    [SerializeField] public bool UseSkillAnim;





    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Time.timeScale = 1;
        randomnum2 = 99;

        //Timer = 5;
        //TimeCount = Timer;
        //fireTimer = 1;
        //fireTimeCount = fireTimer;
        
    }

    private void Update()
    {
        

        if (gameObject.GetComponent<Boss>().currentHP <= 0)
        {
            DeadAnim = true;
            Time.timeScale = 1;
            WinGUI.SetActive(true);

        }

        if (GameLose == true)
        {
            Time.timeScale = 1;
            LoseGUI.SetActive(true);
        }

        if (!isCount)
        {


            TimeCount = TimeCount - Time.deltaTime;
            if (!TimeCheck) { 

            if (TimeCount <= 0)
            {

                isCount = true;


                TimeCount = Timer;


            }
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

        MoneyUi.text =MoneyText + Money.ToString();

        BlockFireShow1(randomnum1);
        BlockFireShow2(randomnum2);
        //Debug.Log(randomnum2);
    }
    public void SettingGUIOpen()
    {
        Time.timeScale = 0;
        SettingGUI.SetActive(true);
    }
    public void CloseGUI()
    {
        Time.timeScale = 1;
        SettingGUI.SetActive(false);
    }

    public void RunTime()
    {
        Time.timeScale = 1;
    }

    public void TakeICE()
    {
        if (!oneTimeICE)
        {
            TimeCount = TimeCount + Timer;
            oneTimeICE = true;
        }

    }
    public void TakeFreeze()
    {
        if (!oneTimeFreeze)
        {
            TimeCount = TimeCount + (Timer * 3);
            oneTimeFreeze = true;
        }
    }


    public void TakeMoney(int MoneyEarn)
    {
        if (!TakeMoneyOneTime)
        {
            TakeMoneyOneTime = true;
            Money = Money + MoneyEarn;
            TakeMoneyOneTime = false;
        }
      
    }

    public void TakePsy()
    {
        Take64 = true;
    }

    public void TakeGravity()
    {
        StartCoroutine(GravityGun());
    }

    IEnumerator GravityGun()
    {
        yield return new WaitForSeconds(0);
        Take64 = true;
        yield return new WaitForSeconds(1.5f);  
        Take64 = true;
        yield return new WaitForSeconds(1.5f);
        Take64 = true;
    }

    public void Take64Block()
    {
        Take64 = true;
    }

    public void BuyWeapon(int MoneyValue)
    {
        Money = Money - MoneyValue;
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
