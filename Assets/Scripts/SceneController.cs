using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("GAME");
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("HOME");
    }

}
