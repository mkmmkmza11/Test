using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlockMove : GameManager
{
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
        //TimeCount = TimeCount - Time.deltaTime;
        if (TimeCount <= 0)
        {
            GanZ -= 1;
            LeanTween.moveLocalZ(gameObject, GanZ, 1);
            TimeCount = Timer;
            if (GanZ <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
