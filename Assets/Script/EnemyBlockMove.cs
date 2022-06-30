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
    public bool onetime;
    
    
    //public Material[] newMaterialRef;
    //[SerializeField] TextMeshProUGUI m_Object;
    // Start is called before the first frame update
    void Start()
    {
        
        GanZ = this.transform.position.z;
        
        int rounded = (int)Mathf.Ceil(GanZ);
        GanZ = rounded;
        Debug.Log(rounded+ "GanZ");
        LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, GanZ), 0.1f);

    }   

    // Update is called once per frame
    void Update()
    {
       

        if (GameManager.instance.isCount)
        {
            if (!onetime)
            {
                onetime = true;
                StartCoroutine(MovingBlock());
                Debug.Log(gameObject.name + "Moving");
            }

        }
        if (gameObject.GetComponent<RaycastBlock>().isForward == true)
        {
            LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + 1), 1);
            gameObject.GetComponent<RaycastBlock>().isForward = false;
        }
        
    }

    public void MoveBlock()
    {
        GanZ = GanZ - 1;
        
        LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - 1), 1);
        
        //return;
    }


    IEnumerator MovingBlock()
    {
        MoveBlock();
        yield return new WaitForSeconds(0.5f);
        GameManager.instance.isCount = false;
        onetime = false;
    }
}
