using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pressE : MonoBehaviour
{
    private bool hasCollided = false;
    private string labelText = "";
    private GameObject stone;


    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e") && hasCollided)
        {
            stone = GameObject.FindGameObjectWithTag("stone");
 

            while (counter != 10)
            {
                stone.transform.position += new Vector3(0,0,1);
                Debug.Log(stone.transform.position.z);
                counter++;
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

}
