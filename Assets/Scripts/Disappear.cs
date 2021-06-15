using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    private bool hasCollided = false;
    private string labelText = "";
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var playerProperties = player.GetComponent<PlayerProperties>();
        if (Input.GetKey("e") && hasCollided)
        {
            player.GetComponent<PlayerProperties>().SetKeys(playerProperties.keys + 1);
            Destroy(gameObject);
        }
    }
    private void OnGUI()
    {
        if (hasCollided == true)
        {
            GUI.Box(new Rect(140, Screen.height - 50, Screen.width - 300, 120), (labelText));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hasCollided = true;
            labelText = "Hit E to interact!";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        hasCollided = false;
    }
}
