using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteBook : MonoBehaviour
{

    public GameObject wall;
    //public int note;
    public Text collected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
        Destroy(wall);
        //note++;
        collected.text = "Notebooks: 2/4";
    }

}
