using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerObservator : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");                   /* rotation around the Y axis */
        pitch -= speedV * Input.GetAxis("Mouse Y");                 /* rotation around the X axis */

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
