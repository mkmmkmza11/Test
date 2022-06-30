using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalZ(gameObject, 10, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<RaycastBlock>().isEnter == true)
        {
            LeanTween.cancel(this.gameObject);
            gameObject.AddComponent<EnemyBlockMove>();
            Destroy(this);
        }
    }
    
}
