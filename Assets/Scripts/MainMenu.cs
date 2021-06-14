using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Earth", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
