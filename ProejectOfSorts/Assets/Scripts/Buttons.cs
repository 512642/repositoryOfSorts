using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{


    public void TryAgain()
    {
        SceneManager.LoadScene("GameScreen");
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void QuitGame()
    {
        print("quit game");
        Application.Quit();
    }
}
