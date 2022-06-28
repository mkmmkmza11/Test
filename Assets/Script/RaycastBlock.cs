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
    //public int ValueCheck;


    private void Start()
    {
        value = 2;
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
            isEnter = true;
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

    public void ChangeComponent()
    {
        //gameObject
        //gameObject.GetComponent<MoveFire>().
        //Destroy(gameObject.MoveFire);
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
