using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
    private bool hasCollided = false;
    private string labelText = "";
    private GameObject ChestOpen;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ChestOpen = GameObject.FindGameObjectWithTag("chestopen");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e") && hasCollided)
        {
            var playerProperties = player.GetComponent<PlayerProperties>();
            if (playerProperties.keys >= 1)
            {
                player.GetComponent<PlayerProperties>().SetCoins(playerProperties.coins + 5);
                player.GetComponent<PlayerProperties>().SetKeys(playerProperties.keys - 1);
                Destroy(gameObject);
                GameObject newChest = Instantiate(ChestOpen);
            }
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



    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        if (parsed != 0)
    //        {
    //            countercoin += 5;
    //            GameObject.FindGameObjectWithTag("coins").GetComponent<Text>().text = countercoin.ToString();
    //            parsed -= 1;
    //            GameObject.FindGameObjectWithTag("keys").GetComponent<Text>().text = parsed.ToString();
    //            Destroy(gameObject);
    //            GameObject newChest = Instantiate(chestopen);
    //        }
    //    }
    //}
}
