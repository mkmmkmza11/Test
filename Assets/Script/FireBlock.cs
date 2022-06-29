using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBlock : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform muzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            //BlockFire.AddComponent<MoveFire>();
        }
    }
    public virtual void Fire()
    {
        
        if (GameManager.instance.fireisCount==true)
        {
            GameManager.instance.fireisCount = false;
            GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            //BlockFire.AddComponent<RaycastBlock>();
            if (GameManager.instance.Eis2 == true)
            {
                BlockFire.GetComponent<RaycastBlock>().is2 = true;
            }
            else if (GameManager.instance.Eis4 == true)
            {
                BlockFire.GetComponent<RaycastBlock>().is4 = true;
            }
            else if (GameManager.instance.Eis8 == true)
            {
                BlockFire.GetComponent<RaycastBlock>().is8 = true;
            }
            else if (GameManager.instance.Eis16 == true)
            {
                BlockFire.GetComponent<RaycastBlock>().is16 = true;
            }

            BlockFire.GetComponent<RaycastBlock>().isChecker = false;
            BlockFire.AddComponent<MoveFire>();

            
        }
        
        
        

    }
}
