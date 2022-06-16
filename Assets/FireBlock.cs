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
        
    }
    public virtual void Fire()
    {
        GameObject BlockFire = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
        BlockFire.AddComponent<MoveFire>();
        

    }
}
