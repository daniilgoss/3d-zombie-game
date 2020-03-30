using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenControl : MonoBehaviour {

    // Use this for initialization
    private int counter = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (counter >= 180)
        {
            SceneManager.LoadScene("Menu");
        }

        counter++;
    }
}
