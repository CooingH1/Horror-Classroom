using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Others : MonoBehaviour
{
    public Text collected;
    public GameObject wall;
    void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(wall);
        
        Debug.Log("Quick!");
        collected.text = "Notebooks: 3/4";
    }
}
