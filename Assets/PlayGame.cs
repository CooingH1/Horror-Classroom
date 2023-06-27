using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour
{
    public Transform button;

    public void StartGame()
    {
        Debug.Log("Clicked");
        SceneManager.LoadScene("School");
    }
}