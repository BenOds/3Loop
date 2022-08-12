using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioRandom : MonoBehaviour
{
    public int numeroAleatorio;
    int numberRandom;
    void Start()
    {
        numberRandom = Random.Range(0, numeroAleatorio);
        Debug.Log("El número aleatorio entre 0 y el valor especificado es: " + numberRandom);
        Debug.Log("El número aleatorio entre 0 y " +numeroAleatorio +" es: " + numberRandom);
    }

    void Update()
    {
        
    }
        
}

