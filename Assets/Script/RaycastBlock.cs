using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaycastBlock : MonoBehaviour
{
    [Header("Set Block in Side")]
    public GameObject[] BlockinSide;
    [Header("View Value")]
    [SerializeField] private int value;
    public int Value => value;
    [Header("Set Material")]
    public Material[] newMaterialRef;
    [Header("Set Text")]
    public TextMeshProUGUI m_Object;
    [Header("Set Block")]
    public GameObject BlockMat;
    [Header("Is Check Don't Touch")]
    public bool isChecker;
    public int randomInt;
    public bool isForward;
    public bool is2;
    public bool is4;
    public bool is8;
    public bool is16;
    public bool is32;
    public bool isc;
    public bool isEnter = false;
    public float timecount;
    public bool Onetime64;
    public bool Skill1Onetime;
    RaycastHit Hit;
    public bool oneTimeRandom;
    int Random1;
    public GameObject[] FusePaticle;
    //public int ValueCheck;


    private void Start()
    {
        //timecount = 3;
        NumberBlock();
        //randomInt = Random.Range(0, 99);
        //randomNumber(randomInt);
    }
    private void FixedUpdate()
    {

        m_Object.text = value.ToString();

        SetMat();
        SetBlockinSide();
        
        if (!isChecker)
        {

            if (RaycastCheck(Vector3.forward))
            {
                IsEnter();
                //gameObject.GetComponent<EnemyBlockMove>().MoveBlockUp();
                if (RaycastCheck(Vector3.forward))
                {
                    CheckCollider(Hit.collider);
                    if (isc)
                    {
                        isForward = true;
                        isc = false;
                    }
                    
                }
                if (RaycastCheck(Vector3.left))
                { CheckCollider(Hit.collider); }
                if (RaycastCheck(Vector3.right))
                { CheckCollider(Hit.collider); }

                if (!isChecker)
                {
                    //isChecker = true;
                }


                if (value == 64)
                {
                    StartCoroutine(Destroy64Move());
                }
            }

            
        }
        if (!RaycastCheck(Vector3.forward))
        {
        
            if (timecount <= 0)
            {
                gameObject.GetComponent<EnemyBlockMove>().MoveBlockUp();
            }
        }
        if (timecount >= 0)
        {
            timecount = timecount - Time.deltaTime;
        }


        if (GameManager.instance.Skill1ChangeBox)
        {
            if (!Skill1Onetime)
            {
                Skill1Onetime = true;
                Skill1();

            }
            
        }

    }
    IEnumerator Destroy64Move()
    {
        GameManager.instance.Take64Block();
        yield return new WaitForSeconds(0);
        if (!Onetime64)
        {
            //Onetime64 = true; 
            //GameManager.instance.TakeMoney();
        }
        yield return new WaitForSeconds(1f);
        //Onetime64 = false;
        LeanTween.cancel(this.gameObject);
        Destroy(this.gameObject);
    }

    public void SetMat()
    {
        if (value == 2)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[0];
        }
        else if (value == 4)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else if (value == 8)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[2];
        }
        else if (value == 16)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[3];
        }
        else if (value == 32)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[4];
        }
        else if (value == 64)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[5];
        }
    }

    public void SetBlockinSide()
    {
        if (value == 2)
        {
            BlockinSide[0].SetActive(true);
            BlockinSide[1].SetActive(false);
            BlockinSide[2].SetActive(false);
            BlockinSide[3].SetActive(false);
            BlockinSide[4].SetActive(false);
            BlockinSide[5].SetActive(false);

        }
        else if (value == 4)
        {
            BlockinSide[0].SetActive(false);
            BlockinSide[1].SetActive(true);
            BlockinSide[2].SetActive(false);
            BlockinSide[3].SetActive(false);
            BlockinSide[4].SetActive(false);
            BlockinSide[5].SetActive(false);
        }
        else if (value == 8)
        {
            BlockinSide[0].SetActive(false);
            BlockinSide[1].SetActive(false);
            BlockinSide[2].SetActive(true);
            BlockinSide[3].SetActive(false);
            BlockinSide[4].SetActive(false);
            BlockinSide[5].SetActive(false);
        }
        else if (value == 16)
        {
            BlockinSide[0].SetActive(false);
            BlockinSide[1].SetActive(false);
            BlockinSide[2].SetActive(false);
            BlockinSide[3].SetActive(true);
            BlockinSide[4].SetActive(false);
            BlockinSide[5].SetActive(false);
        }
        else if (value == 32)
        {
            BlockinSide[0].SetActive(false);
            BlockinSide[1].SetActive(false);
            BlockinSide[2].SetActive(false);
            BlockinSide[3].SetActive(false);
            BlockinSide[4].SetActive(true);
            BlockinSide[5].SetActive(false);
        }
        else if (value == 64)
        {
            BlockinSide[0].SetActive(false);
            BlockinSide[1].SetActive(false);
            BlockinSide[2].SetActive(false);
            BlockinSide[3].SetActive(false);
            BlockinSide[4].SetActive(false);
            BlockinSide[5].SetActive(true);
        }




    }

    public void setTimecount()
    {
        timecount = 0;
    }

    void IsEnter()
    {
        if(!isChecker)
        isEnter = true;

    }

    void CheckCollider(Collider hit)
    {
        if (!isChecker)
        {
            RaycastBlock SlotAttack = hit.GetComponent<RaycastBlock>();
            if (value == SlotAttack.Value)
            {
                Debug.Log("equal");
                // total
                
                value = CalculateTotal(hit.GetComponent<RaycastBlock>().Value);
                if (!Onetime64)
                {
                    Onetime64 = true;
                    if (value == 64)
                    {
                        StartCoroutine(setFusePaticle(1));
                    }
                    else
                    {
                        StartCoroutine(setFusePaticle(0));
                    }
                    TimeCountEndless.instance.GetScore(Value);
                    GameManager.instance.TakeMoney(value);
                }
                Onetime64 = false;
                Debug.Log("trigger");
                    var farwardPos = hit.transform.position.z;
                isc = true;
                
                Destroy(SlotAttack.gameObject);
               

            }

            
        }
    }

    IEnumerator setFusePaticle(int block)
    {
        FusePaticle[block].SetActive(true);
        yield return new WaitForSeconds(3);
        FusePaticle[block].SetActive(false);
    }

    public int CalculateTotal(int valueB)
    {
        return value + valueB;

    }

    bool RaycastCheck(Vector3 direction)
    {
        //RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(direction), out Hit, 0.9f, 1 << 6))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(direction) * Hit.distance, Color.red);
            Debug.Log("Did Hit Forward");
            //CheckCollider(hit.collider);
            //Hit = hit;
            return true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(direction) * Hit.distance, Color.green);
            return false;
        }
    }


    public void NumberBlock()
    {
        if (is2 == true)
        {
            value = 2;
        }
        else if (is4 == true)
        {
            value = 4;
        }
        else if (is8 == true)
        {
            value = 8;
        }
        else if (is16 == true)
        {
            value = 16;
        }
        else if (is32 == true)
        {
            value = 32;
        }
    }

    public void Skill1()
    {
        value = 2;
    }

    public void RandomInt()
    {
        
        if (!oneTimeRandom)
        {
            if (GameManager.instance.Takepsy == true)
            {
                oneTimeRandom = true;

                Random1 = Random.Range(0, 4);
                if (Random1 == 0)
                {
                    value = 2;
                }
                if (Random1 == 1)
                {
                    value = 4;
                }
                if (Random1 == 2)
                {
                    value = 8;
                }
                if (Random1 == 3)
                {
                    value = 16;
                }
                if (Random1 == 4)
                {
                    value = 32;
                }
                StartCoroutine(Randoming());
            }
        }
      

    }

    IEnumerator Randoming()
    {
        yield return new WaitForSeconds(1);
        GameManager.instance.Takepsy = false;
        oneTimeRandom = false;

    }
    }
