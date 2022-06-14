using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject blockIsShot;

    void ShooterBlock()
    {
        Instantiate(blockIsShot);
    }

    void SpwanBlocks(int amount)
    {
        //var freeNodes = _nodes.Where(n=>n.OccupiedBlock == null).OrderBy(b=>Random.value);

        for (int i = 0; i < amount; i++){
            //var block = Instantiate(_blockPrefab);
        }
    }



    
}
