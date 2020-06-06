using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class categoryselectionscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackButton () {
        SceneManager.LoadScene("MainMenu");
    }
    public void Animals () {
        SceneManager.LoadScene("AnimalSelection");
    }
    public void Buildings () {
        SceneManager.LoadScene("BuildingSelection");
    }

    public void Cars () {
        SceneManager.LoadScene("CarSelection");
    }
    public void Plant () {
        SceneManager.LoadScene("PlantSelection");
    }

    //HOW TO PAGE
    public void OpenLink (){
        Application.OpenURL("https://drive.google.com/file/d/1XETrWfU6oL9I__XcFwS-Y3J7cnAb4Cum/view?usp=sharing");
    }
}
