using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XCamera : MonoBehaviour
{

    public Camera main;

    public float sensitivity = 5f; // Adjust this to control the camera rotation speed

    private float rotationX = 0f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        rotationX += mouseX;

        transform.rotation = Quaternion.Euler(0f, rotationX, 0f);
    }
}