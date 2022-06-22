using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlockMove : MonoBehaviour
{
    public GameManager gameManager;
    //public float Timer;
    //[SerializeField] private float TimeCount;
    public int GanZ;
    // Start is called before the first frame update
    void Start()
    {
        
        GanZ = ((int)this.transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isCount)
        {
            //TimeCount = TimeCount - Time.deltaTime;

            
            GanZ = ((int)this.transform.position.z);

            LeanTween.moveZ(gameObject, GanZ-1, 1).setOnComplete(()=>gameManager.isCount=false);
            //GanZ -= 1;

            if (GanZ <= 0)
            {
                Destroy(gameObject);
            }

        }

    }
}
