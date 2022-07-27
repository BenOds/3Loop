using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int number;

    void Start()
    {
        SumNumberWithFor();
        string cadena01 = "Cadena ";
        string cadena02 = "de caracteres";

        string adición = cadena01 + cadena02;

        Debug.Log(adición);

    }

    void Update()
    {
        
    }

    void SumNumberWithFor()
    {   
        int sum = 0;
        string result = "";

        for(int i = 1; i <= number; i++)
        {
            sum +=i;
            result += i + ",";
        }

        Debug.Log(result.Substring (0, result.Length - 2));
    }


}
