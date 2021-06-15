using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnPoint;
    private bool triggeredFlag = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        player.transform.position = spawnPoint.transform.position;
        player.transform.rotation = spawnPoint.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (!triggeredFlag)
        {
            if (player == null)
            {
                player = GameObject.FindWithTag("Player");
            }

            if (player != null)
            {
                player.transform.position = spawnPoint.transform.position;
                player.transform.rotation = spawnPoint.transform.rotation;
                triggeredFlag = true;
            }
        }

        if (SceneManager.GetActiveScene().name == "moon")
        {
            player.transform.localScale = new Vector3(10, 10, 10);
            player.GetComponent<PlayerMovement>().walkSpeed = 50f;
            player.GetComponent<PlayerMovement>().runSpeed = 100f;
        }
    }
}
