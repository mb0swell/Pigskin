using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_Button : MonoBehaviour
{
   public void Options_Menu_Main_Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
