using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Weapon : MonoBehaviour
{
    [Header("WeaponText")]
    public TextMeshProUGUI LaserText;
    public TextMeshProUGUI BigLaserText;
    public TextMeshProUGUI ICEText;
    public TextMeshProUGUI FreezeText;
    public TextMeshProUGUI PsyText;
    public TextMeshProUGUI GravityText;
    public TextMeshProUGUI LighingText;
    public TextMeshProUGUI ThunderText;

    [Header("Laser")]
    public int LaserValue;
    public int LaserDamage;
    public float LaserCount;
    public float LaserTimer;
    [Header("BigLaser")]
    public int BigLaserValue;
    public int BigLaserDamage;
    public float BigLaserCount;
    public float BigLaserTimer;
    [Header("ICE")]
    public int ICEValue;
    public int ICEDamage;
    public float ICECount;
    public float ICETimer;
    [Header("Freeze")]
    public int FreezeValue;
    public int FreezeDamage;
    public float FreezeCount;
    public float FreezeTimer;
    [Header("Psy")]
    public int PsyValue;
    public int PsyDamage;
    public float PsyCount;
    public float PsyTimer;
    [Header("Gravity")]
    public int GravityValue;
    public int GravityDamage;
    public float GravityCount;
    public float GravityTimer;
    [Header("Lighing")]
    public int LighingValue;
    public int LighingDamage;
    public float LighingCount;
    public float LighingTimer;
    [Header("Thunder")]
    public int ThunderValue;
    public int ThunderDamage;
    public float ThunderCount;
    public float ThunderTimer;

    private void Update()
    {
        TimeUpdate();

        LaserText.text = LaserValue.ToString();
        BigLaserText.text = BigLaserValue.ToString();
        ICEText.text = ICEValue.ToString();
        FreezeText.text = FreezeValue.ToString();
        PsyText.text = PsyValue.ToString();
        LighingText.text = LighingValue.ToString();
        ThunderText.text = ThunderValue.ToString();
        


    }

    // Start is called before the first frame update

    public void TimeUpdate()
    {
        LaserCount = LaserCount - Time.deltaTime;
        BigLaserCount = BigLaserCount - Time.deltaTime;
        ICECount = ICECount - Time.deltaTime;
        FreezeCount = FreezeCount - Time.deltaTime;
        PsyCount = PsyCount - Time.deltaTime;
        LighingCount = LighingCount - Time.deltaTime;
        ThunderCount = ThunderCount - Time.deltaTime;
    }
    public void Laser()
    {
        if (GameManager.instance.Money >= LaserValue)
        {
            if (LaserCount <= 0)
            {
                
                gameObject.GetComponent<Boss>().TakeDamage(LaserDamage);
                GameManager.instance.BuyWeapon(LaserValue);
                LaserCount = LaserTimer;
            }

        }
    }

    public void BigLaser()
    {
        if (GameManager.instance.Money >= BigLaserValue)
        {
            if (BigLaserCount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(BigLaserDamage);
                GameManager.instance.BuyWeapon(BigLaserValue);
                BigLaserCount = BigLaserTimer;
            }

        }
    }

    public void ICE()
    {
        if (GameManager.instance.Money >= ICEValue)
        {
            if (ICECount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(ICEDamage);
                GameManager.instance.BuyWeapon(ICEValue);
                GameManager.instance.TakeICE();
                ICECount = ICETimer;
            }

        }
    }

    public void Freeze()
    {
        if (GameManager.instance.Money >= FreezeValue)
        {
            if (FreezeCount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(FreezeDamage);
                GameManager.instance.BuyWeapon(FreezeValue);
                GameManager.instance.TakeFreeze();
                FreezeCount = FreezeTimer;
            }

        }
    }

    public void Psy()
    {
        if (GameManager.instance.Money >= PsyValue)
        {
            if (PsyCount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(PsyDamage);
                GameManager.instance.BuyWeapon(PsyValue);
                GameManager.instance.TakePsy();
                PsyCount = PsyTimer;
            }

        }
    }

    public void Gravity()
    {
        if (GameManager.instance.Money >= GravityValue)
        {
            if (PsyCount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(GravityDamage);
                GameManager.instance.BuyWeapon(GravityValue);
                GameManager.instance.TakeGravity();
                PsyCount = PsyTimer;
            }

        }
    }

    public void Lighing()
    {
        if (GameManager.instance.Money >= LighingValue)
        {
            if (LighingCount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(LighingDamage);
                GameManager.instance.BuyWeapon(LighingValue);
                LighingCount = LighingTimer;
            }

        }
    }

    public void Thunder()
    {
        if (GameManager.instance.Money >= ThunderValue)
        {
            if (ThunderCount <= 0)
            {
                gameObject.GetComponent<Boss>().TakeDamage(ThunderDamage);
                GameManager.instance.BuyWeapon(ThunderValue);
                ThunderCount = ThunderTimer;
            }

        }
    }






}
