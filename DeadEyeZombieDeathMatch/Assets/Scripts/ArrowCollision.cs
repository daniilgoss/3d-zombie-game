using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollision : MonoBehaviour {

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
            Destroy(col.transform.root.gameObject);
        }
    }
}
