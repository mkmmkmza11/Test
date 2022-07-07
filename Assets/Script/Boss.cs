using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int MaxHP;
    public int currentHP;
    //public int LaserValue;
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

    public void TakeDamage(int Damage)
    {
        
        currentHP -= Damage;
        hpBar.SetHp(currentHP);
        DelayDamage();
       
    }

    IEnumerator DelayDamage()
    {
        yield return new WaitForSeconds(0);
        GameManager.instance.TakeDamageAnim = true;
        yield return new WaitForSeconds(1);
        GameManager.instance.TakeDamageAnim = false;

    }


    


}
