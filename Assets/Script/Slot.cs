using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{

    [SerializeField] private int x;
    [SerializeField] private int z;
    [SerializeField] private int value;

    [SerializeField] private Text valueText;


    [SerializeField] public bool isChecker;

    private void Start()
    {
        x = (int)transform.position.x;
        z = (int)transform.position.z;


    }




    /*private void FixedUpdate()
    {
        valueText.text = value.ToString();
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit Forward");









        }
        else
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            Debug.Log("Did not Hit");
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), out hit, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.back) * hit.distance, Color.yellow);
            Debug.Log("Did Hit Back");
        }
        else
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            Debug.Log("Did not Hit");
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.yellow);
            Debug.Log("Did Hit Left");
        }
        else
        {

        }
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            Debug.Log("Did not Hit");
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.yellow);
            Debug.Log("Did Hit Rigth");
        }
        else
        {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
            Debug.Log("Did not Hit");
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (isChecker)
        {
            //    Slot slotAttack = other.GetComponent<Slot>();
            //    if (value == slotAttack.Value)
            //    {
            //        Debug.Log("equal");
            //        // total
            //        value = CalculateTotal(other.GetComponent<Slot>().Value);
            //    }

            //    Debug.Log("trigger");
            //    var farwardPos = other.transform.position;
            //    gameObject.transform.position = farwardPos;
            //    //LeanTween.moveLocalZ(gameObject, 10, .5f);
            //    Destroy(slotAttack.gameObject);
            //}

            if (other.gameObject.tag == "EnemyBlock")
            {
                //LeanTween.moveLocalZ(gameObject, 10, .5f);
            }
        }



        //public int CalculateTotal(int valueB)
        //{
        //    return value + valueB;

        //}

        ///*public void IsShoot()
        //{
        //    LeanTween.moveLocalZ(gameObject, 10, 1);


    }
}
