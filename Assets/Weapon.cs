using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
    [Header("WeaponCooldownText")]
    public TextMeshProUGUI LaserCooldownText;
    public TextMeshProUGUI BigLaserCooldownText;
    public TextMeshProUGUI ICECooldownText;
    public TextMeshProUGUI FreezeCooldownText;
    public TextMeshProUGUI PsyCooldownText;
    public TextMeshProUGUI GravityCooldownText;
    public TextMeshProUGUI LighingCooldownText;
    public TextMeshProUGUI ThunderCooldownText;
    [Header("ImageCooldown")]
    public Image LaserCooldownImage;
    public Image BigLaserCooldownImage;
    public Image ICECooldownImage;
    public Image FreezeCooldownImage;
    public Image PsyCooldownImage;
    public Image GravityCooldownImage;
    public Image LighingCooldownImage;
    public Image ThunderCooldownImage;
    [Header("Paticle Gameobject")]
    public GameObject[] LaserPaticle;
    public GameObject[] BigLaserPaticle;
    public GameObject[] ICEPaticle;
    public GameObject[] FreezePaticle;
    public GameObject[] PsyPaticle;
    public GameObject[] GravityPaticle;
    public GameObject[] LighingPaticle;
    public GameObject[] ThunderPaticle;



    int A1,A2,A3,A4,A5,A6,A7,A8;

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

    private void Start()
    {
        LaserCooldownImage.gameObject.SetActive(false);
        BigLaserCooldownImage.gameObject.SetActive(false);
        ICECooldownImage.gameObject.SetActive(false);
        FreezeCooldownImage.gameObject.SetActive(false);
        PsyCooldownImage.gameObject.SetActive(false);
        GravityCooldownImage.gameObject.SetActive(false);
        LighingCooldownImage.gameObject.SetActive(false);
        ThunderCooldownImage.gameObject.SetActive(false);

        LaserCooldownImage.fillAmount = 0f;
        BigLaserCooldownImage.fillAmount = 0f;
        ICECooldownImage.fillAmount = 0f;
        FreezeCooldownImage.fillAmount = 0f;
        PsyCooldownImage.fillAmount = 0f;
        GravityCooldownImage.fillAmount = 0f;
        LighingCooldownImage.fillAmount = 0f;
        ThunderCooldownImage.fillAmount = 0f;

        LaserCooldownText.gameObject.SetActive(false);
        BigLaserCooldownText.gameObject.SetActive(false);
        ICECooldownText.gameObject.SetActive(false);
        FreezeCooldownText.gameObject.SetActive(false);
        PsyCooldownText.gameObject.SetActive(false);
        GravityCooldownText.gameObject.SetActive(false);
        LighingCooldownText.gameObject.SetActive(false);
        ThunderCooldownText.gameObject.SetActive(false);


    }

    private void Update()
    {
       

        LaserText.text = LaserValue.ToString();
        BigLaserText.text = BigLaserValue.ToString();
        ICEText.text = ICEValue.ToString();
        FreezeText.text = FreezeValue.ToString();
        PsyText.text = PsyValue.ToString();
        GravityText.text = GravityValue.ToString();
        LighingText.text = LighingValue.ToString();
        ThunderText.text = ThunderValue.ToString();

        A1 = (int)LaserCount;
        A2 = (int)BigLaserCount;
        A3 = (int)ICECount;
        A4 = (int)FreezeCount;
        A5 = (int)PsyCount;
        A6 = (int)GravityCount;
        A7 = (int)LighingCount;
        A8 = (int)ThunderCount;




        LaserCooldownText.text = A1.ToString();
        BigLaserCooldownText.text = A2.ToString();
        ICECooldownText.text = A3.ToString();
        FreezeCooldownText.text = A4.ToString();
        PsyCooldownText.text = A5.ToString();
        GravityCooldownText.text = A6.ToString();
        LighingCooldownText.text = A7.ToString();
        ThunderCooldownText.text = A8.ToString();

        TimeUpdate();


    }

    // Start is called before the first frame update

    public void TimeUpdate()
    {
        if (LaserCount >= 0)
        {
            LaserCooldownText.gameObject.SetActive(true);
            LaserCooldownImage.gameObject.SetActive(true);
            LaserCooldownImage.fillAmount = LaserCount / LaserTimer;
            LaserCount = LaserCount - Time.deltaTime;
        }
        else
        {
            LaserCooldownImage.gameObject.SetActive(false);
            LaserCooldownText.gameObject.SetActive(false);
        }

        if (BigLaserCount >= 0)
        {
            BigLaserCooldownText.gameObject.SetActive(true);
            BigLaserCooldownImage.gameObject.SetActive(true);
            BigLaserCooldownImage.fillAmount = BigLaserCount / BigLaserTimer;
            BigLaserCount = BigLaserCount - Time.deltaTime;
        }
        else
        {
            BigLaserCooldownText.gameObject.SetActive(false);
            BigLaserCooldownImage.gameObject.SetActive(false);
        }
        if (ICECount >= 0)
        {
            ICECooldownText.gameObject.SetActive(true);
            ICECooldownImage.gameObject.SetActive(true);
            ICECooldownImage.fillAmount = ICECount / ICETimer;
            ICECount = ICECount - Time.deltaTime;
        }
        else
        {
            ICECooldownText.gameObject.SetActive(false);
            ICECooldownImage.gameObject.SetActive(false);
        }
        if (FreezeCount >= 0)
        {
            FreezeCooldownText.gameObject.SetActive(true);
            FreezeCooldownImage.gameObject.SetActive(true);
            FreezeCooldownImage.fillAmount = FreezeCount / FreezeTimer;
            FreezeCount = FreezeCount - Time.deltaTime;
        }
        else
        {
            FreezeCooldownText.gameObject.SetActive(false);
            FreezeCooldownImage.gameObject.SetActive(false);
        }
        if (PsyCount >= 0)
        {
            PsyCooldownText.gameObject.SetActive(true);
            PsyCooldownImage.gameObject.SetActive(true);
            PsyCooldownImage.fillAmount = PsyCount / PsyTimer;
            PsyCount = PsyCount - Time.deltaTime;
        }
        else
        {
            PsyCooldownText.gameObject.SetActive(false);
            PsyCooldownImage.gameObject.SetActive(false);
        }
        if (GravityCount >= 0)
        {
            GravityCooldownText.gameObject.SetActive(true);
            GravityCooldownImage.gameObject.SetActive(true);
            GravityCooldownImage.fillAmount = GravityCount / GravityTimer;
            GravityCount = GravityCount - Time.deltaTime;
        }
        else
        {
            GravityCooldownText.gameObject.SetActive(false);
            GravityCooldownImage.gameObject.SetActive(false);
        }
        if (LighingCount >= 0)
        {
            LighingCooldownText.gameObject.SetActive(true);
            LighingCooldownImage.gameObject.SetActive(true);
            LighingCooldownImage.fillAmount = LighingCount / LighingTimer;
            LighingCount = LighingCount - Time.deltaTime;
        }else
        {
            LighingCooldownText.gameObject.SetActive(false);
            LighingCooldownImage.gameObject.SetActive(false);
        }
        if (ThunderCount >= 0)
        {
            ThunderCooldownText.gameObject.SetActive(true);
            ThunderCooldownImage.gameObject.SetActive(true);
            ThunderCooldownImage.fillAmount = ThunderCount / ThunderTimer;
            ThunderCount = ThunderCount - Time.deltaTime;
        }
        else
        {
            ThunderCooldownText.gameObject.SetActive(false);
            ThunderCooldownImage.gameObject.SetActive(false);
        }












    }
    public void Laser()
    {
        if (GameManager.instance.Money >= LaserValue)
        {
            if (LaserCount <= 0)
            {
                
                gameObject.GetComponent<Boss>().TakeDamage(LaserDamage);
                GameManager.instance.BuyWeapon(LaserValue);
                StartCoroutine(LaserPaticleActive());
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
                StartCoroutine(BigLaserPaticleActive());
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
                StartCoroutine(ICEPaticleActive());
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
                StartCoroutine(FreezePaticleActive());
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
                StartCoroutine(PsyPaticleActive());
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
                StartCoroutine(GravityPaticleActive());
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
                StartCoroutine(LighingPaticleActive());
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
                StartCoroutine(ThunderPaticleActive());
                ThunderCount = ThunderTimer;
            }

        }
    }



    IEnumerator LaserPaticleActive()
    {
        LaserPaticle[0].SetActive(true);
        LaserPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        LaserPaticle[0].SetActive(false);
        LaserPaticle[1].SetActive(false);
    }

    IEnumerator BigLaserPaticleActive()
    {
        BigLaserPaticle[0].SetActive(true);
        BigLaserPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        BigLaserPaticle[0].SetActive(false);
        BigLaserPaticle[1].SetActive(false);
    }

    IEnumerator ICEPaticleActive()
    {
        ICEPaticle[0].SetActive(true);
        ICEPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        ICEPaticle[0].SetActive(false);
        ICEPaticle[1].SetActive(false);
    }

    IEnumerator FreezePaticleActive()
    {
        FreezePaticle[0].SetActive(true);
        FreezePaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        FreezePaticle[0].SetActive(false);
        FreezePaticle[1].SetActive(false);
    }

    IEnumerator PsyPaticleActive()
    {
        PsyPaticle[0].SetActive(true);
        PsyPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        PsyPaticle[0].SetActive(false);
        PsyPaticle[1].SetActive(false);
    }

    IEnumerator GravityPaticleActive()
    {
        GravityPaticle[0].SetActive(true);
        GravityPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        GravityPaticle[0].SetActive(false);
        GravityPaticle[1].SetActive(false);
    }

    IEnumerator LighingPaticleActive()
    {
        LighingPaticle[0].SetActive(true);
        LighingPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        LighingPaticle[0].SetActive(false);
        LighingPaticle[1].SetActive(false);
    }

    IEnumerator ThunderPaticleActive()
    {
        ThunderPaticle[0].SetActive(true);
        ThunderPaticle[1].SetActive(true);
        yield return new WaitForSeconds(1.5f);
        ThunderPaticle[0].SetActive(false);
        ThunderPaticle[1].SetActive(false);
    }
}
