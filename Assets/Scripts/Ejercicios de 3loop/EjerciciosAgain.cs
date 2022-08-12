using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosAgain : MonoBehaviour
{
    int a = 10;
    int b = 5;
    int perímetro;
    int area;

    void Start()
    {
        rectangle();
        Debug.Log(""+ area);
    }

    void Update()
    {
        
    }

    void rectangle()
    {
        int perímetro = (a + b) * 2;
        int area = a* b;
        Debug.Log(""+ area + perímetro);
        
    }
}
