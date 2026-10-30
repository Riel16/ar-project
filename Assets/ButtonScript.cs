using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void TombolExit()
    {
        Application.Quit();
        Debug.Log("Aplikasi di tutup");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void ARCamera()
    {
        SceneManager.LoadScene("SimpleScene");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Credit()
    {
        SceneManager.LoadScene("Credit");
    }

}