using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkill : MonoBehaviour
{
    [Header("Skill 1 Activate ")]
    public bool SkillChangeBox;
    public float SkillChangeBoxTimer;
    public float SkillChangeBoxCount;
    [Header("Skill 2 Activate ")]
    public bool SkillCanNotSwitch;
    public float SkillCanNotSwitchTimer;
    public float SkillCanNotSwitchCount;
    [Header("Skill 3 Passive ")]
    public bool SkillMostWeaponValue;
    [Header("Skill 4 Activate")]
    public bool SkillStealMoney;
    public float SkillStealMoneyTimer;
    public float SkillStealMoneyCount;
    [Header("Skill 5 Activate")]
    public bool SkillHealing;
    public float SkillHealingTimer;
    public float SkillHealingCount;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeBox();
        CanNotSwap();
        MostValue();
        StealYouMoney();
    }


    public void ChangeBox()
    {
        if(!GameManager.instance.Skill1ChangeBox)
        if (SkillChangeBoxCount>=0)
        {
            SkillChangeBoxCount = SkillChangeBoxCount - Time.deltaTime;
        }
       
        
        if (SkillChangeBox)
        {
            if(SkillChangeBoxCount <= 0)
            {
                Debug.Log("Skill1Activate");
                SkillChangeBoxCount = SkillChangeBoxTimer;
                GameManager.instance.Skill1ChangeBox = true;
                GameManager.instance.UseSkillAnim = true;

            }
        }
    }

    public void CanNotSwap()
    {
        if (!GameManager.instance.Skill2Swap)
            if (SkillCanNotSwitchCount >= 0)
            {
                SkillCanNotSwitchCount = SkillCanNotSwitchCount - Time.deltaTime;
            }


        if (SkillCanNotSwitch)
        {
            if (SkillChangeBoxCount <= 0)
            {
                Debug.Log("Skill2Activate");
                SkillCanNotSwitchCount = SkillCanNotSwitchTimer;
                GameManager.instance.Skill2Swap = true;
                GameManager.instance.UseSkillAnim = true;

            }
        }
    }

    public void MostValue()
    {

        if (SkillMostWeaponValue)
        {
            GameManager.instance.Skill3Value = true;
        }


    }

    public void StealYouMoney()
    {
        if (!GameManager.instance.Skill2Swap)
            if (SkillStealMoneyCount >= 0)
            {
                SkillStealMoneyCount = SkillStealMoneyCount - Time.deltaTime;
            }


        if (SkillStealMoney)
        {
            if (SkillStealMoneyCount <= 0)
            {
                Debug.Log("Skill2Activate");
                SkillStealMoneyCount = SkillStealMoneyTimer;
                GameManager.instance.Skill4Steal = true;
                GameManager.instance.UseSkillAnim = true;

            }
        }
    }
    public void Healing()
    {
        if (!GameManager.instance.Skill5Heal)
            if (SkillHealingCount >= 0)
            {
                SkillHealingCount = SkillHealingCount - Time.deltaTime;
            }


        if (SkillHealing)
        {
            if (SkillHealingCount <= 0)
            {
                Debug.Log("Skill2Activate");
                SkillHealingCount = SkillHealingTimer;
                GameManager.instance.Skill5Heal = true;
                GameManager.instance.UseSkillAnim = true;
            }
        }
    }

}
