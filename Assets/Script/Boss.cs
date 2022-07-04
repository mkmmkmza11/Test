using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int MaxHP;
    public int currentHP;
    public int LaserValue;
    public HpBar hpBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
        hpBar.SetMaxHp(MaxHP);  
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.SetHp(currentHP);

        

    }

    void TakeDamage(int Damage)
    {
        currentHP -= Damage;
        hpBar.SetHp(currentHP);
    }


    public void Laser()
    {
        if (GameManager.instance.Money >= LaserValue)
        {
            TakeDamage(10);
            GameManager.instance.BuyWeapon(LaserValue);
        }
    }


}
