using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 0.98f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speedV);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speedV);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speedV);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speedV);
        }

        yaw += speedH * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
