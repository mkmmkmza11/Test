using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float MaxHP;
    public int currentHP;
    //public int LaserValue;
    public HpBar hpBar;
    public int precentHeal;
    public bool Endless;
    public bool BossDead;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = (int)MaxHP;
        hpBar.SetMaxHp((int)MaxHP);  
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.SetHp(currentHP);


        if (currentHP > MaxHP)
        {
            currentHP = (int)MaxHP;
        }
    }

    public void TakeDamage(int Damage)
    {
        
        currentHP -= Damage;
        hpBar.SetHp(currentHP);
        DelayDamage();
        if (currentHP <= 0)
        {
            BossDead = true;
        }
    }

    IEnumerator DelayDamage()
    {
        yield return new WaitForSeconds(0);
        GameManager.instance.TakeDamageAnim = true;
        yield return new WaitForSeconds(1);
        GameManager.instance.TakeDamageAnim = false;

    }

    public void BossHealing()
    {
        currentHP = currentHP + ((int)MaxHP * precentHeal / 100);
    }

    public void BossDied()
    {
        if (Endless)
        {
            if (BossDead)
            {
                TimeCountEndless.instance.GetScore((int)MaxHP);
                MaxHP = MaxHP * 1.1f;
                currentHP = (int)MaxHP;


            }
        }
        


    }
    


}
