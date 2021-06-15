using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProperties : MonoBehaviour
{
    public int keys { get; private set; }
    public int coins { get; private set; }

    
    public GameObject coinsTextField;
    
    public GameObject keysTextField;

    public void Start()
    {
        Debug.Log("newKeys");
        SetKeys(0);
        SetCoins(0);
    }

    public void SetKeys(int newKeys)
    {
        keys = newKeys;
        Debug.Log(newKeys);
        keysTextField.GetComponent<Text>().text = newKeys.ToString();
    }
    
    public void SetCoins(int newCoins)
    {
        coins = newCoins;
        coinsTextField.GetComponent<Text>().text = newCoins.ToString();
    }
}
