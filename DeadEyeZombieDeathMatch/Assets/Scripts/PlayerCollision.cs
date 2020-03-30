using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        //Debug.LogError(col.transform.root.tag);
        if (col.transform.root.tag.Equals("Enemy"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
