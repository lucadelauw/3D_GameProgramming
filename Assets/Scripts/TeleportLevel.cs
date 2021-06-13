using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class TeleportLevel : MonoBehaviour
{
    public string LevelToLoad;

    public void OnCollisionEnter(Collision collision)
    {
        if (this.tag == "End" && collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
