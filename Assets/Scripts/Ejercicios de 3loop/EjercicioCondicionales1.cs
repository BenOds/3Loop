using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioCondicionales1 : MonoBehaviour
{

// -------------- VARIABLES --------------
    int numberOne;
    int numberTwo;
    int numberThree;
    int numberFour;
    public char letter;

    char lowerLetter;

// --------------- MÉTODOS --------------
    void Start()
    {
        numberOne = Random.Range(-100,100);
        numberTwo = Random.Range(-100,100);
        Debug.Log("Nuestro numero elgido es "+numberOne);
        
        lowerLetter = char.ToLower(letter);
        Debug.Log(lowerLetter);       
        
        // NumberSignal();
        // NumberAscent();
        Vocal();
        // NumberDays();
        // NumberAscent3();
        // NumberOrder();

                

    }

    void Update()
    {
    }

// EJERCICIO 1 ---------------

    int NumberSignal()
    {
        if(numberOne >= 0)
        {
            Debug.Log("El Número " +numberOne +" es positivo");
        }
        else
        {
            Debug.Log("El Número " +numberOne +" es negativo");
        }
        return 0;
    }

// EJERCICIO 2 ---------------

    int NumberPar()
    {
        return 0;
    }

// EJERCICIO 3 ---------------
    int NumberAscent()
    {
        Debug.Log(numberOne+" "+numberTwo);

        if(numberOne>numberTwo)
        {
            Debug.Log("El orden ascendente de entre estos dos numeros es 1: " +numberTwo +" 2: " +numberOne);
        }
        else
        {
             Debug.Log("El orden ascendente de entre estos dos numeros es 1: " +numberOne +" 2: " +numberTwo);
        }    
        return 0;
    }

// EJERCICIO 4 ---------------

    void Vocal()
    {
        //Lowercase sensivity


        if(lowerLetter == 'a' || lowerLetter == 'e' || lowerLetter == 'i' || lowerLetter == 'o' || lowerLetter == 'u')
        {
            Debug.Log("La letra " +letter +" es una vocal");
        }
        else
        {
            Debug.Log("La letra " +letter +" no es una vocal");

        }
    }

// EJERCICIO 5 Y 6 ---------------

    void NumberDays()
    {
        numberThree = Random.Range(1,7);
        Debug.Log("Numero de día: " +numberThree);

        if( numberThree == 1)
        {
            Debug.Log(" El dia de la semana correspondiente al número 1 es Lunes");
        }

        else if( numberThree == 2)
        {
            Debug.Log(" El dia de la semana correspondiente al número 2 es Martes");
        }
        
        else if( numberThree == 3)
        {
            Debug.Log(" El dia de la semana correspondiente al número 3 es Miércoles");
        }
        
        else if( numberThree == 4)
        {
            Debug.Log(" El dia de la semana correspondiente al número 4 es Jueves");
        }
        
        else if( numberThree == 5)
        {
            Debug.Log(" El dia de la semana correspondiente al número 5 es Viernes");
        }
        
        else if( numberThree == 6)
        {
            Debug.Log(" El dia de la semana correspondiente al número 6 es Sábado");
        }
        
        else
        {
            Debug.Log(" El dia de la semana correspondiente al número 7 es Domingo");
        }
    }

// EJERCICIO 7, 8 ---------------

    void NumberAscent3()
    {   
        int first = 0;
        int second = 0;
        int third = 0;

        if(numberOne>numberTwo)
        {
            first = numberOne;

            if (numberTwo>numberThree)
            {
                second = numberTwo;
                third = numberThree;
            }
            else
            {
                second = numberThree;
                third = numberTwo;
            }
        }
        else if (numberTwo>numberThree)
        {
            first = numberTwo;

            if (numberOne>numberThree)
            {
                second = numberOne;
                third = numberThree;
            }
            else
            {
                second = numberThree;
                third = numberOne;
            }
        }
        else
        {
            first = numberThree;
            second = numberTwo;
            third = numberOne;
        }

        Debug.Log("El primer número es "+ numberOne);
        Debug.Log("El segundo número es "+ numberTwo);
        Debug.Log("El tercer número es "+ numberThree);
        Debug.Log("El orden ascendente sería: " + third +", "+ second +" y " + first);
        Debug.Log("El orden descendente sería: " + first +", "+ second +" y " + third);
    }

// EJERCICIOS 9 Y 10 ---------------------
    void NumberOrder()
    {
        if (numberOne<numberTwo && numberTwo<numberThree)
        {
            Debug.Log("El orden de introducción de valores se ha hecho en un orden CRECIENTE");
        }
        else
        {
            Debug.Log("El orden de introducción de valores NO se ha hecho en un orden CRECIENTE");
        }

        if (numberOne>numberTwo && numberTwo>numberThree)
        {
            Debug.Log("El orden de introducción de valores se ha hecho en un orden DECRECIENTE");
        }
        else
        {
            Debug.Log("El orden de introducción de valores NO se ha hecho en un orden DECRECIENTE");
        }
    }
}
