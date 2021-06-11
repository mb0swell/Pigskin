using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void Practice_Menu()
    {
        SceneManager.LoadScene("Practice Menu");
    }

    public void Quit_Game()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
