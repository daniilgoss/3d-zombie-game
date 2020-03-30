using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour {

    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu"); // Loads in the scene which has the first Index. Since Menu has 0 Index, therefore Start of the Game needs to be Scene 1.

    }

}
