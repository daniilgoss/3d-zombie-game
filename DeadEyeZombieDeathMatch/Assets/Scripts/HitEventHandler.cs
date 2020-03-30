using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitEventHandler : MonoBehaviour {

	public bool isHit;

	// Use this for initialization
	void Start () {
		isHit = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isHit) {
			Destroy(gameObject);
		}
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.LogError(col.gameObject.tag);
        Debug.LogError(col.transform.root.tag);
        if (col.gameObject.tag.Equals("Arrow"))
        {
            Destroy(this.gameObject);
        }
        if (col.transform.root.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
