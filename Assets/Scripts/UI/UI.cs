using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// hay que añadir la librería "Text Mesh Pro" y trabajar textos de interfaz
using TMPro;

public class UI : MonoBehaviour
{
    public TMP_Text textUI;
    public TMP_Text text;
    public TMP_Sprite sprite;
    
    void Start()
    {
       // textUI = GetComponent<TextMeshPro>().text;
       textUI.text = "nouses";
    }

    void Update()
    {
        
    }
}
