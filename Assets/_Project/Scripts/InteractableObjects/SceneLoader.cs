using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Title()
    {
        SceneManager.LoadScene("Title");
    }

    void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    void Game()
    {
        SceneManager.LoadScene("Game");
    }

    void Results()
    {
        SceneManager.LoadScene("Results");
    }
}
