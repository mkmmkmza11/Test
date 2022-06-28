using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    //public GameManager gameManager;
    public GameObject bulletPrefab;
    public Transform muzzle;
    //public float Timer;
    //[SerializeField] private float TimeCount;
    // Start is called before the first frame update

    private bool Onetime =false;
    void Start()
    {
        
        //TimeCount = Timer;
       //TimeCount = Timer;
    }
    
    // Update is called once per frame
    void Update()
    {

        if (!Onetime) {

            //TimeCount = TimeCount - Time.deltaTime;
            if (GameManager.instance.isCount)
            {
                Onetime = true;
                FireBlock();
                if (GameManager.instance.isCount == false)
                {
                    Onetime = false;
                }
                /*GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
                BlockFire.AddComponent<EnemyBlockMove>();*/

                // TimeCount = Timer;
            }
        }
    }
    public virtual void FireBlock()
    {
        GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        //BlockFire.AddComponent<RaycastBlock>(); 
        BlockFire.GetComponent<RaycastBlock>().isChecker = true;
        BlockFire.AddComponent<EnemyBlockMove>();

        

    }
}
