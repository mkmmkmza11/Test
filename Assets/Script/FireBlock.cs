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
            GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            BlockFire.AddComponent<MoveFire>();
        }
    }
    public virtual void Fire()
    {
        GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        //BlockFire.AddComponent<RaycastBlock>();
        BlockFire.GetComponent<RaycastBlock>().isChecker = false;
        BlockFire.AddComponent<MoveFire>();
        

    }
}
