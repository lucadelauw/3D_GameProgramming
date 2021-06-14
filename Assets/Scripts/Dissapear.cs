using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissapear : MonoBehaviour
{
    static int counter = 0;
    private bool hasCollided = false;
    private string labelText = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e") && hasCollided)
        {
            counter++;
            GameObject.FindGameObjectWithTag("keys").GetComponent<Text>().text = counter.ToString();
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
