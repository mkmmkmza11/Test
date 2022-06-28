using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class EnemyBlockMove : MonoBehaviour
{
    //public GameManager gameManager;
    //public float Timer;
    //[SerializeField] private float TimeCount;
    public float GanZ;
    
    //public Material[] newMaterialRef;
    //[SerializeField] TextMeshProUGUI m_Object;
    // Start is called before the first frame update
    void Start()
    {
        
        GanZ = this.transform.position.z;
        
        int rounded = (int)Mathf.Ceil(GanZ);
        GanZ = rounded;
        Debug.Log(rounded);
        LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, GanZ), 0.1f);

    }   

    // Update is called once per frame
    void Update()
    {
       

        if (GameManager.instance.isCount)
        {

            //GanZ = ((int)this.transform.position.z);
            GanZ = GanZ-1;
            //GanZ = ((int)this.transform.position.z);
            //Debug.Log(GanZ-1);    
            LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 1), 1);
            GameManager.instance.isCount = false;
            return;
            //GanZ -= 1;    
           
            /*if (GanZ <= 0)
            {
                gameObject.SetActive(false);
            }*/

        }

    }
}
