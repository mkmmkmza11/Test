using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject CanvasGameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBlock")
        {
            Time.timeScale = 0;
            CanvasGameOver.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
