using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioNotas : MonoBehaviour
{

    // nota final - nota de prácticas - nota de teoría. Teoría 70% y práctica 30%

    float notaFinal;
    int notaPrácticas;
    int notaTeoría;

    float notaPorcentajePrácticas;
    float notaPorcentajeTeoría;    
    void Start()
    {
         notaPrácticas = Random.Range(0,10);
        //notaPrácticas = 10;
         notaTeoría = Random.Range(0,10);
        //notaTeoría = 10;

        notaPorcentajeTeoría = notaTeoría * 0.7f;
        notaPorcentajePrácticas = notaPrácticas * 0.3f;
        notaFinal = (notaTeoría * 0.7f)+(notaPrácticas * 0.3f);



        Debug.Log("Nota de teoría " +notaTeoría + " y su porcentaje de la nota final es "+ notaPorcentajeTeoría);
        Debug.Log("Nota de prácticas " +notaPrácticas + " y su porcentaje de la nota final es " + notaPorcentajePrácticas);
    
        Debug.Log("La nota final es " + notaFinal);
    }

    void Update()
    {
        
    }
    void nuevoMétodo()
    {
        Debug.Log("Le estamos indicando que haga esta acción que no necesita interactuar con el resto del código");
    }
    int nuevoMétodo2()
    {
        int number = 0;
        Debug.Log(number);
        return number;
    }
    



    
}
