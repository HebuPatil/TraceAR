using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class overlayscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void AnimalExitButton () {
        SceneManager.LoadScene("AnimalSelection");
    }
    public void BuildingExitButton () {
        SceneManager.LoadScene("BuildingSelection");
    }
    public void CarExitButton () {
        SceneManager.LoadScene("CarSelection");
    }
    public void PlantExitButton () {
        SceneManager.LoadScene("PlantSelection");
    }
}
