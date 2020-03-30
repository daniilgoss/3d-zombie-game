using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{

    private static Singleton _instance;

    [Range(.001f, 5f)]
    public static float Sensitivity = 1f;

    [Range(.001f, 1f)]
    public static float SoundLevel = .5f;

    public static bool EasyMode = false;
    public static Singleton Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if ((_instance != null) && (_instance != this))
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
