using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteBook1 : MonoBehaviour
{
    public GameObject yes;
    public GameObject Upset;
    public AudioSource Music;
    public GameObject wall;
    //public int note;
    public Text collected;

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(yes);
        Upset.SetActive(true);
        Destroy(Music);
        Destroy(wall);
        Debug.Log("Grabbed!");
        //note++;
        collected.text = "Notebooks: 1/4";

    }
}
