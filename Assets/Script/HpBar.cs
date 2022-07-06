using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxHp(int Hp)
    {
        slider.maxValue = Hp;
        slider.value = Hp;
    }

    public void SetHp(int Hp)
    {
        slider.value = Hp;
    }
}
