using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RaycastBlock : MonoBehaviour
{

    [SerializeField] private int value;
    RaycastHit Hit;
    public bool isEnter=false;
    // Start is called before the first frame update
    public int Value => value;
    public Material[] newMaterialRef;
    public TextMeshProUGUI m_Object;
    public bool isChecker;
    public GameObject BlockMat;
    public int randomInt;

    public bool is2;
    public bool is4;
    public bool is8;
    public bool is16;
    public bool is32;
    //public int ValueCheck;


    private void Start()
    {
        NumberBlock();
        //randomInt = Random.Range(0, 99);
        //randomNumber(randomInt);
    }
    private void FixedUpdate()
    {

        m_Object.text = value.ToString();


        if (value == 2)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[0];
        }
        else if (value == 4)
        {
            BlockMat.GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else BlockMat.GetComponent<Renderer>().material = newMaterialRef[0];


        //RaycastHit Hit;
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit, 2, 1<<6))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * Hit.distance, Color.red);
        //    Debug.Log("Did Hit Forward");
        //    //CheckCollider(hit.collider);
        //    //Hit = hit;
        //    //return true;
        //}
        //ValueCheck = value;
        if (RaycastCheck(Vector3.forward))
        {
            IsEnter();
            CheckCollider(Hit.collider);
            //if (RaycastCheck(Vector3.back))
            //{
            //    CheckCollider(Hit.collider);
            //}
            //if (RaycastCheck(Vector3.forward))
            //{
            //    CheckCollider(Hit.collider);
            //}
            //if (RaycastCheck(Vector3.left))
            //{
            //    CheckCollider(Hit.collider);
            //}
            //if (RaycastCheck(Vector3.right))
            //{
            //    CheckCollider(Hit.collider);
            //}
        }




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
                
                    Debug.Log("trigger");
                    var farwardPos = hit.transform.position.z;
                    //gameObject.transform.position = farwardPos;
                    //LeanTween.moveLocalZ(gameObject, 10, .5f);
                    if (SlotAttack.isChecker)
                    {
                        Destroy(SlotAttack.gameObject);
                    
                }
                LeanTween.moveLocalZ(gameObject, farwardPos, 1f);


            }

            
        }
    }

    public int CalculateTotal(int valueB)
    {
        return value + valueB;

    }

    bool RaycastCheck(Vector3 direction)
    {
        //RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(direction), out Hit, 2, 1<<6))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(direction) * Hit.distance, Color.red);
            Debug.Log("Did Hit Forward");
            //CheckCollider(hit.collider);
            //Hit = hit;
            return true;
        }
        else Debug.DrawRay(transform.position, transform.TransformDirection(direction) * Hit.distance, Color.green);
        return false;
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


        //public void ChangeColor()
        //{
        //    var CubeRederer = gameObject.GetComponent<Renderer>();
        //    CubeRederer.material.SetColor("_Color", Color.red);
        //    GameObject BlockThis = gameObject;
        //    BlockThis.GetComponent < Renderer>();
        //    BlockThis.material.SetColor("_Color", Color.red);
        //    //var cubeRenderer = gameObject.GetComponent<Renderer>();
        //}
    }
