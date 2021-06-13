using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour
{
    static string counter = "";
    int parsed = 0;

    public GameObject chestopen;


    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("keys").GetComponent<Text>().text;
        parsed = int.Parse(counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (parsed != 0)
            {
                parsed -= 1;
                GameObject.FindGameObjectWithTag("keys").GetComponent<Text>().text = counter.ToString();
                Destroy(gameObject);
                GameObject newChest = Instantiate(chestopen);
            }
        }
    }
}
