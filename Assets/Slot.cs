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


    [SerializeField] private bool isChecker; 
    
    private void Start()
    {
        x = (int)transform.position.x;
        z = (int)transform.position.z;

        
    }

    public int Value => value;


    private void OnTriggerEnter(Collider other)
    {
        if (isChecker)
        {
            Slot slotAttack = other.GetComponent<Slot>();
            if (value == slotAttack.Value)
            {
                Debug.Log("equal");
                // total
                value = CalculateTotal(other.GetComponent<Slot>().Value);
            }

            Debug.Log("trigger");
            var farwardPos = other.transform.position;
            gameObject.transform.position = farwardPos;
            //LeanTween.moveLocalZ(gameObject, 10, .5f);
            //Destroy(slotAttack.gameObject);
        }

        if (other.gameObject.tag == "EnemyBlock")
        {
            LeanTween.moveLocalZ(gameObject, 10, .5f);
        }
    }



    public int CalculateTotal(int valueB)
    {
        return value + valueB;
    }

    /*public void IsShoot()
    {
        LeanTween.moveLocalZ(gameObject, 10, 1);

    }*/
}
