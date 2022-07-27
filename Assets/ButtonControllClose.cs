using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControllClose : MonoBehaviour
{
    


    public void CloseMenu(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
