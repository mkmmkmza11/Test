using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockShot : MonoBehaviour
{
    public float SpeedBlock ;


    // Start is called before the first frame update
    void Start()
    {
        SpeedBlock = 350;
    }

    // Update is called once per frame
    void Update()
    {
        
        GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, SpeedBlock * Time.deltaTime));
    }

    void Forward()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyBlock")
        {
            
            SpeedBlock = -50;
        }
        else SpeedBlock = 350;


        
    }

    


}
