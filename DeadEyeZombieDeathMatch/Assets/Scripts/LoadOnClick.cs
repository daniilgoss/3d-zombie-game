using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadOnClick : MonoBehaviour
{

    // Use this for initialization
    public void LoadScene(int level = 1)
    {
        SceneManager.LoadScene(level);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void fin(int ignoreLevel)
    {
        Debug.Log("quit called");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        // set the PlayMode to stop
#else
         Application.Quit();
#endif
    }
}
