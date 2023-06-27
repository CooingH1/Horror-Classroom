using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT : MonoBehaviour
{
    public void Update()
    {
        Application.Quit(3);
        Debug.Log("QUIT!");
    }
}