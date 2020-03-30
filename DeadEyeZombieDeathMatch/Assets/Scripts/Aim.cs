using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {
    [SerializeField]
    float mouseSensitivity = 1;
    [SerializeField]
    bool invertAim = false;
    Rigidbody rb;
    [SerializeField]
    Camera cam;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        AimLogic();
	}

    void AimLogic()
    {
        int _aimModifier = -1;
        if(invertAim)
        {
            _aimModifier = 1;
        }
        float _leftRightValue = Input.GetAxisRaw("Mouse X");
        float _upDownValue = _aimModifier*Input.GetAxisRaw("Mouse Y");
        Vector3 _rotationX = new Vector3(_upDownValue, 0, 0);
        Vector3 _rotationY = new Vector3(0, _leftRightValue, 0);

        rb.MoveRotation(rb.rotation * Quaternion.Euler(_rotationY));
        cam.transform.Rotate(_rotationX / mouseSensitivity);
        cam.transform.Rotate(_rotationY / mouseSensitivity);
    }
}
