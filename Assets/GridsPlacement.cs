using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridsPlacement : MonoBehaviour
{

    public GameObject _squre;
    public int width = 5;
    public int height = 9;
    public GameObject[,] gridsTable;
    void Start()
    {
        for (int x = 0; x < 5; x++)
        {
            for (int z = 0; z < 9; z++)
            {
                // Instantiate
                GameObject square = Instantiate(_squre);
                square.transform.position = new Vector3(square.transform.position.x + x, square.transform.position.y, square.transform.position.z + z);
                square.transform.SetParent(gameObject.transform);
                // gridsTable[x, z] = square;
            }
        }
    }

    
}
