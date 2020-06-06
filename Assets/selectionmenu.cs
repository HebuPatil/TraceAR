using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectionmenu : MonoBehaviour
{
    public void BackButton () {
        SceneManager.LoadScene("CategorySelection");
    }

    /*///////////////////
    //////ANIMALS////////
    ///////////////////*/
    public void Drawing_Horse () {
        SceneManager.LoadScene("Drawing_Horse");
    }
    public void Drawing_Dragon () {
        SceneManager.LoadScene("Drawing_Dragon");
    }
    public void Drawing_Tiger () {
        SceneManager.LoadScene("Drawing_Tiger");
    }
    public void Drawing_Lion () {
        SceneManager.LoadScene("Drawing_Lion");
    }

    /*///////////////////
    //////BUILDINGS//////
    ///////////////////*/
    public void Drawing_Eiffel () {
        SceneManager.LoadScene("Drawing_Eiffel");
    }
    public void Drawing_Burj () {
        SceneManager.LoadScene("Drawing_Burj");
    }
    public void Drawing_Taj () {
        SceneManager.LoadScene("Drawing_Taj");
    }
    public void Drawing_Statue () {
        SceneManager.LoadScene("Drawing_Statue");
    }
    /*///////////////////
    //////CARS///////////
    ///////////////////*/

    public void Drawing_Lambo () {
        SceneManager.LoadScene("Drawing_Lambo");
    }
    public void Drawing_Must () {
        SceneManager.LoadScene("Drawing_Must");
    }
    public void Drawing_Vintage () {
        SceneManager.LoadScene("Drawing_Vintage");
    }
    public void Drawing_Audi () {
        SceneManager.LoadScene("Drawing_Audi");
    }
    /*///////////////////
    //////PLANTS/////////
    ///////////////////*/
    public void Drawing_Rose () {
            SceneManager.LoadScene("Drawing_Rose");
    }
    public void Drawing_Rhatany () {
            SceneManager.LoadScene("Drawing_Rhatany");
    }
    public void Drawing_Crocus () {
            SceneManager.LoadScene("Drawing_Crocus");
    }
    public void Drawing_Cotton () {
            SceneManager.LoadScene("Drawing_Cotton");
    }
}
