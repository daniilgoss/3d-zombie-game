using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("Main"); // Loads in the scene which has the first Index. Since Menu has 0 Index, therefore Start of the Game needs to be Scene 1.

    }

    public void QuitGame() {

        Debug.Log("Quit!"); //Should output 'Quit!' When executed.
        Application.Quit();
    }



}
