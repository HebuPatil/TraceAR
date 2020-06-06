using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_script : MonoBehaviour
{
    public void PlayGame () {
        SceneManager.LoadScene("CategorySelection");
    }
    public void QuitGame () {
        Debug.Log("Exiting DrawAR...");
        Application.Quit();
    }
    public void HowGame () {
        SceneManager.LoadScene("HowTo");
    }
}
