using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockFireShow : MonoBehaviour
{
    public Material[] newMaterialRef;
    public TextMeshProUGUI[] m_Object;
    public bool isChecker;
    public GameObject[] BlockMat;
    public int randomInt;
    public int value1, value2;
    public bool is2;
    public bool is4;
    public bool is8;
    public bool is16;
    public bool is32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NumberBlock();
       

        m_Object[0].text = value1.ToString();
        m_Object[1].text = value2.ToString();


        if (value1 == 2)
        {
            BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[0];
        }
        else if (value1 == 4)
        {
            BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[0];

        if (value2 == 2)
        {
            BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[0];
        }
        else if (value2 == 4)
        {
            BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[0];
    }

    public void SetNumber()
    {
        


        
    }

    public void NumberBlock()
    {
        if (GameManager.instance.Eis2 == true)
        {
            value1 = 2;
        }
        else if (GameManager.instance.Eis4 == true)
        {
            value1 = 4;
        }
        else if (GameManager.instance.Eis8 == true)
        {
            value1= 8;
        }
        else if (GameManager.instance.Eis16 == true)
        {
            value1= 16;
        }



        if (GameManager.instance.E1is2 == true)
        {
            value2 = 2;
        }
        else if (GameManager.instance.E1is4 == true)
        {
            value2 = 4;
        }
        else if (GameManager.instance.E1is8 == true)
        {
            value2 = 8;
        }
        else if (GameManager.instance.E1is16 == true)
        {
            value2 = 16;
        }
    }
}
