using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.08f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 0.08f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.08f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.08f);
        }

        yaw += speedH * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
