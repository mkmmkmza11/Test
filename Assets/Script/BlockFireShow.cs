using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlockFireShow : MonoBehaviour
{
    [Header("Set ImageUi")]
    public Image[] ImagesUi;
    [Header("Set Image")]
    public Sprite[] ImagesShow;
    [Header("Set TextUI")]
    public TextMeshProUGUI[] TextShow;
    [Header("Set TextColor")]
    public Material[] TextColor;
    

    [Header("Is check Don't touch")]
    public bool isChecker;
    public int randomInt;
    public int value1, value2;
    public bool is2;
    public bool is4;
    public bool is8;
    public bool is16;
    //public bool is32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NumberBlock();
       

        TextShow[0].text = value1.ToString();
        TextShow[1].text = value2.ToString();

        SetImage();

        

    }

    public void SetImage()
    {

        if (value1 == 2)
        {
            ImagesUi[0].GetComponent<Image>().sprite = ImagesShow[0];
            TextShow[0].GetComponent<Renderer>().material = TextColor[0];

            //BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[0];
        }
        else if (value1 == 4)
        {
            ImagesUi[0].GetComponent<Image>().sprite = ImagesShow[1];
            TextShow[0].GetComponent<Renderer>().material = TextColor[1];
            // BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else if (value1 == 8)
        {
            ImagesUi[0].GetComponent<Image>().sprite = ImagesShow[2];
            TextShow[0].GetComponent<Renderer>().material = TextColor[2];
            // BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else if (value1 == 16)
        {
            ImagesUi[0].GetComponent<Image>().sprite = ImagesShow[3];
            TextShow[0].GetComponent<Renderer>().material = TextColor[3];
        }
        // BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[1];
        //}else if (value1 == 32)
        //{
        //    ImagesUi[0].GetComponent<Image>().sprite = ImagesShow[0];
        //   // BlockMat[0].GetComponent<Renderer>().material = newMaterialRef[1];
        //}


        if (value2 == 2)
        {
            ImagesUi[1].GetComponent<Image>().sprite = ImagesShow[0];
            TextShow[1].GetComponent<Renderer>().material = TextColor[0];
            //BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[0];
        }
        else if (value2 == 4)
        {
            ImagesUi[1].GetComponent<Image>().sprite = ImagesShow[1];
            TextShow[1].GetComponent<Renderer>().material = TextColor[1];
            // BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else if (value2 == 8)
        {
            ImagesUi[1].GetComponent<Image>().sprite = ImagesShow[2];
            TextShow[1].GetComponent<Renderer>().material = TextColor[2];
            // BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[1];
        }
        else if (value2 == 16)
        {
            ImagesUi[1].GetComponent<Image>().sprite = ImagesShow[3];
            TextShow[1].GetComponent<Renderer>().material = TextColor[3];
            // BlockMat[1].GetComponent<Renderer>().material = newMaterialRef[1];
        }


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
