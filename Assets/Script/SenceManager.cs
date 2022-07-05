using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SenceManager : MonoBehaviour
{
    public float progress;
    public string NameScene;

    public void LoadSceneGame(string sceneName)
    {
        Debug.Log("Load");
        //SceneManager.LoadScene(sceneName);
        StartCoroutine(SceneStart(sceneName));
        //SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
    }
    



    public IEnumerator SceneStart(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        asyncOperation.allowSceneActivation = false;
        while (!asyncOperation.isDone)
        {
            progress = Mathf.Clamp01(asyncOperation.progress / 0.9f);
            if(progress == 1)
            {
                Debug.Log("LoadScene");
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
