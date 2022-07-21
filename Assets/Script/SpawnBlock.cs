using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    //public GameManager gameManager;
    public GameObject bulletPrefab;
    public Transform muzzle;
    public int randomInt;
    //public float Timer;
    //[SerializeField] private float TimeCount;
    // Start is called before the first frame update

    private bool Onetime =false;
    void Start()
    {
        randomInt = Random.Range(0, 99);
        //randomNumber(randomInt);

        //TimeCount = Timer;
        //TimeCount = Timer;
    }

    // Update is called once per frame
    void Update()
    {

        
            //TimeCount = TimeCount - Time.deltaTime;
            if (GameManager.instance.isCount)
            {
            
            if (Onetime == false)
            {
                FireBlock();
                Onetime = true;
                
                randomInt = Random.Range(0, 99);
            }
                
                /*GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
                BlockFire.AddComponent<EnemyBlockMove>();*/

                // TimeCount = Timer;
            }
        if (GameManager.instance.isCount == false)
        {
            Onetime = false;
        }

    }
    public virtual void FireBlock()
    {
        GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        //BlockFire.AddComponent<RaycastBlock>();
        if (randomInt >= 60)
        {
            BlockFire.gameObject.name = "2";
            BlockFire.GetComponent<RaycastBlock>().is2 = true;
        }
        else if (randomInt >= 40)
        {
            BlockFire.gameObject.name = "4";
            BlockFire.GetComponent<RaycastBlock>().is4 = true;
        }
        else if (randomInt >= 20)
        {
            BlockFire.gameObject.name = "8";
            BlockFire.GetComponent<RaycastBlock>().is8 = true;
        }
        else if (randomInt >= 5)
        {
            BlockFire.gameObject.name = "16";
            BlockFire.GetComponent<RaycastBlock>().is16 = true;
        }
        else
        {
            BlockFire.gameObject.name = "32 ";
            BlockFire.GetComponent<RaycastBlock>().is32 = true;
        }
        BlockFire.GetComponent<RaycastBlock>().isChecker = true;
        BlockFire.AddComponent<EnemyBlockMove>();
        

        

    }

    
    }
