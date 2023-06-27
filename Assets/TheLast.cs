using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheLast : MonoBehaviour
{
    public Text collected;
    public GameObject theend;

    void OnMouseDown()
    {
        Destroy(theend);
        Destroy(gameObject);
        Debug.Log("Get Out!");
        collected.text = "Notebooks: 4/4";
    }
}
