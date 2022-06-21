using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Timer=5;
    [SerializeField] protected float TimeCount;

    private void Start()
    {
        
        Timer = 5;
        TimeCount = Timer;
    }

    private void Update()
    {
        TimeCount = TimeCount - Time.deltaTime;
        if (TimeCount <= 0)
            TimeCount = Timer;

    }
    


}
