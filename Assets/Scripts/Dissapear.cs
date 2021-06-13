using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissapear : MonoBehaviour
{
    static int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            counter += 1;
            GameObject.FindGameObjectWithTag("keys").GetComponent<Text>().text = counter.ToString();
            Destroy(gameObject);
        }
    }
}
