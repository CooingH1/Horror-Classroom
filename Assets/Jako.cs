using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jako : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("JakoMan"); 
    }
}