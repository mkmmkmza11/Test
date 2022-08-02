using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [Header("SetLevelMap")]
    public int LevelMap;

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
    public bool Endless;

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
    public bool Takepsy;

    public bool GameLose;
    public bool TakeMoneyOneTime;

    public bool TimeCheck;

    public bool Skill1ChangeBox;
    public bool Skill2Swap;
    public bool Skill3Value;
    
    public bool Skill4Steal;
    public int PercentSteal;

    public bool GameTimeLose;
    public bool TakeDamage;
    public bool Skill5Heal;
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

        if (!Endless)
        {
            if (gameObject.GetComponent<Boss>().currentHP <= 0)
            {
                DeadAnim = true;
                Time.timeScale = 0;
                WinGUI.SetActive(true);
                PlayerPrefs.SetInt("LevelMap", 1);



                if (LevelMap >= PlayerPrefs.GetInt("LevelMap"))
                {
                    PlayerPrefs.SetInt("LevelMap", LevelMap);
                }



            }
            
        }

        if (Endless)
        {
            if(gameObject.GetComponent<Boss>().currentHP <= 0)
            {
                DeadAnim = true;
            }
            if (gameObject.GetComponent<Boss>().currentHP >= 1)
            {
                DeadAnim = false;
            }
        }

        if (GameLose == true)
        {
            Time.timeScale = 0;
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

        Skill1Activition();
        Skill2Activition();
        Skill4Activition();
    }

   

    public void Skill1Activition()
    {
        if (Skill1ChangeBox)
        {
            StartCoroutine(Skill1Activate());
        }
    }
    
    IEnumerator Skill1Activate()
    {
        yield return new WaitForSeconds(1.5f);
            Skill1ChangeBox = false;
        gameObject.GetComponent<RaycastBlock>().Skill1Onetime = false;

        
    }

    public void Skill2Activition()
    {
        if (Skill2Swap)
        {
            StartCoroutine(Skill2Activate());
        }
    }

    IEnumerator Skill2Activate()
    {
        yield return new WaitForSeconds(10);
        Skill2Swap = false;
        


    }

    public void Skill4Activition()
    {
        if (Skill4Steal)
        {
            StartCoroutine(Skill4Activate());
        }
    }

    IEnumerator Skill4Activate()
    {
        Money = Money - (Money % PercentSteal);
        yield return new WaitForSeconds(0);
        Skill4Steal = false;



    }
    public void Skill5Activition()
    {
        if (Skill4Steal)
        {
            StartCoroutine(Skill5Activate());
        }
    }

    IEnumerator Skill5Activate()
    {
        gameObject.GetComponent<Boss>().BossHealing();
        yield return new WaitForSeconds(0);
        Skill5Heal = false;



    }

    public void SettingGUIOpen(GameObject Gui)
    {
        Time.timeScale = 0;
        Gui.SetActive(true);
    }
    public void CloseGUI(GameObject Gui)
    {
        Time.timeScale = 1;
        Gui.SetActive(false);
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
        Takepsy = true;
    }

    public void TakeGravity()
    {
        Take64 = true;
    }

    

    public void Take64Block()
    {
        Take64 = true;
    }

    public void BuyWeapon(int MoneyValue)
    {
        Money = Money - MoneyValue;
        TakeDamageAnim = true;

    }

    public void SwitchNumber()
    {
        if (!Skill2Swap)
        {
            int wait1 = randomnum1;
            int wait2 = randomnum2;

            randomnum1 = wait2;
            randomnum2 = wait1;
        }

        



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
