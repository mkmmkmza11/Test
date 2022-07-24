using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPointer : MonoBehaviour , IPointerDownHandler, IPointerUpHandler
{
    public bool OnClick;
    public float Timer;
    public GameObject Canvas;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
        
        
        
            OnClick = true;

        





    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
           
            OnClick = false;
        
        Timer = 0;







        Debug.Log("The mouse click was released");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {

        if (OnClick)
        {
            Timer = Timer + Time.deltaTime;
        }
        

        if(Timer >= 3)
        {
            Canvas.SetActive(true);
        }
    }
}
