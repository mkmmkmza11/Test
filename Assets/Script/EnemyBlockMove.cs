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
    public bool IsFor;
    public bool onetimereal;
    public bool onetimeUp;
    //public Material[] newMaterialRef;
    //[SerializeField] TextMeshProUGUI m_Object;
    // Start is called before the first frame update
    private void Awake()
    {
       

    }



    void Start()
    {
        
            GanZ = this.transform.position.z;
        if (!onetimereal)
        {
            if (IsFor)
            {
                Debug.Log("Isfor true");
                //GanZ = GanZ + 1;
                IsFor = false;
            }
        }
        if (!IsFor)
        {
            Debug.Log("isfor false");
        }

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
            LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, GanZ), 1);
            gameObject.GetComponent<RaycastBlock>().isForward = false;
        }
        Block64MoveUp();


    }



    public void Block64MoveUp()
    {
        if(GameManager.instance.Take64==true)
        LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, GanZ + 1), 1).setOnComplete(()=>GameManager.instance.Take64=false);
    }

    public void MoveBlockUp()
    {
        if (!onetimeUp)
        {
            onetimeUp = true;
            GanZ = GanZ + 1;
            if (GanZ >= 11)
            {
                Destroy(this.gameObject);
            }
            LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, GanZ), 1).setOnComplete(()=>onetimeUp=false);
            
        }
    }

    public void MoveBlock()
    {
        //if (!onetimereal)
        //{
        //    if (IsFor)
        //    {
        //        GanZ = GanZ + 1;
        //        onetimereal = true;
        //    }
        //}

        GanZ = GanZ - 1;
        
        LeanTween.move(gameObject, new Vector3(transform.localPosition.x, transform.localPosition.y, GanZ), 1);
        
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
