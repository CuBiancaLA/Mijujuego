using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : MonoBehaviour
{

    public Image progress;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadAsyncOperation());
    }

    IEnumerator LoadAsyncOperation()
    {
        AsyncOperation gameLevel = SceneManager.LoadSceneAsync("Nivel1");

        while(gameLevel.progress < 1)
        {
            progress.fillAmount = gameLevel.progress;
            yield return new WaitForEndOfFrame();
        }

       
    }
       



}
