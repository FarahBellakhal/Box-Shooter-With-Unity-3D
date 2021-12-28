using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerObservator2 : MonoBehaviour
{
    private float horizontalSpeed = 2.0f;
    private float verticalSpeed = 2.0f;

    void Start()
    {
        verrouiller_curseur(true);
    }
    private void verrouiller_curseur(bool v)
    {
        if (v)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }



    void Update()
    {
        if (Input.GetButton("Cancel"))
        
            verrouiller_curseur(false);
        if (Input.GetButton("Fire1"))
        
            verrouiller_curseur(true);
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, h, 0);
    }
}