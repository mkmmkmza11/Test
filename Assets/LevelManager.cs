using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public GameObject[] LevelMapOpen;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckLevelMap();
    }


    public void CheckLevelMap()
    {
        if (PlayerPrefs.GetInt("LevelMap") >= 2)
        {
            LevelMapOpen[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 3)
        {
            LevelMapOpen[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 4)
        {
            LevelMapOpen[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 5)
        {
            LevelMapOpen[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 6)
        {
            LevelMapOpen[4].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 7)
        {
            LevelMapOpen[5].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 8)
        {
            LevelMapOpen[6].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 9)
        {
            LevelMapOpen[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 10)
        {
            LevelMapOpen[8].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 11)
        {
            LevelMapOpen[9].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 12)
        {
            LevelMapOpen[10].SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelMap") >= 13)
        {
            LevelMapOpen[11].SetActive(false);
        }
    }


    
}
