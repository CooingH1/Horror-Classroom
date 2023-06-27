using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notebooks : MonoBehaviour
{
    int coins = 0;

    [SerializeField] Text coinsText;
       

    void OnMouseDown()
    {
        {
            Destroy(gameObject);
            coins++;
            
        }
    }
}