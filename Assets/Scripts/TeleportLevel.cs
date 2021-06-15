using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TeleportLevel : MonoBehaviour
{
    public string levelToLoad;
    private AsyncOperation sceneAsync;
    private GameObject objectToMove;
    private bool activatedFlag = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !activatedFlag)
        {
            if (other.GetComponent<PlayerProperties>().coins >= 15)
            {
                other.GetComponent<PlayerProperties>().SetCoins(other.GetComponent<PlayerProperties>().coins - 15);
                activatedFlag = true;
                objectToMove = other.gameObject; 
                Debug.Log("starting teleport");
                LoadScene(levelToLoad);
            }
        }
    }
    
    private void LoadScene(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(levelToLoad, LoadSceneMode.Additive);
        asyncOperation.completed += OnLoadOperationComplete;
    }

    private void OnLoadOperationComplete(AsyncOperation operation)
    {
        var sceneToLoad = SceneManager.GetSceneByName(levelToLoad);
        SceneManager.MoveGameObjectToScene(objectToMove, sceneToLoad);
        SceneManager.SetActiveScene(sceneToLoad);
        SceneManager.UnloadSceneAsync("Earth");
    }
}
