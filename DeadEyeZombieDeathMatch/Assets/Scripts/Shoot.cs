﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    [SerializeField] float pullSpeed;
    [SerializeField] GameObject arrowPrefab;
    [SerializeField] GameObject arrow;
    [SerializeField] int numberOfArrows = 100;
    [SerializeField] GameObject bow;
    bool arrowSlotted = false;
    float pullAmount = 0;


    // Use this for initialization
    void Start () {
        SpawnArrow();
	}
	
	// Update is called once per frame
	void Update () {
        ShootLogic();
	}

    void SpawnArrow()
    {
        if(numberOfArrows > 0)
        {
            arrowSlotted = true;
            arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as GameObject;
            arrow.transform.parent = transform;
        }
    }

    void ShootLogic()
    {
        if (numberOfArrows > 0)
        {
            if (pullAmount > 100)
                pullAmount = 100;

            SkinnedMeshRenderer _bowSkin = bow.transform.GetComponent<SkinnedMeshRenderer>();
            SkinnedMeshRenderer _arrowSkin = arrow.transform.GetComponent<SkinnedMeshRenderer>();
            Rigidbody _arrowRigidB = arrow.transform.GetComponent<Rigidbody>();
            ProjectileAddForce _arrowProjectile = arrow.transform.GetComponent<ProjectileAddForce>();

            if (Input.GetMouseButton(0))
            {
                pullAmount += Time.deltaTime * pullSpeed;
            }

            if (Input.GetMouseButtonUp(0))
            {
                //print("mouse is up");
                arrowSlotted = false;
                _arrowRigidB.isKinematic = false;
                arrow.transform.parent = null;
                numberOfArrows -= 1;
                _arrowProjectile.shootForce = _arrowProjectile.shootForce * ((pullAmount / 100)+.05f);
                pullAmount = 0;

                _arrowProjectile.enabled= true;
            }

            _bowSkin.SetBlendShapeWeight(0, pullAmount);
            _arrowSkin.SetBlendShapeWeight(0, pullAmount);
            
            if (Input.GetMouseButtonDown(0) && arrowSlotted == false)
                SpawnArrow();
        }
    }
}
