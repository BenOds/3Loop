 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioBucles : MonoBehaviour
{
    public int 
        numberTop;

    
        int randomice;

    public int cajones;
    public int [] unArray;

    string result = "";

    void Start()
    {   
        
        // MiArray();          // Activar para los EX 3, 4, 5, 6 y 7
        // RellenarArray();    // Activar para los EX 3, 4, 5, 6 y 7

        // EX 01
        // Count();
        
        // Ex 02
        // Countdown();
        
        // Ex 03
        // CountPresset();
        
        // Ex 04
        // NumberPositive();

        // EX 05
        // NumberNegative();

        // EX 06
        // NumberImpar();

        // EX 07
        // NumberPar();

        // EX 08
        // NumberMultiple3();

        // EX 09
         NumberMultiple2_3();

        // Ex 10
        // SumaTotal();

    }

    void Update()
    {
        
    }

// EJERCICIO 1  - --- Mostrar los números del 0 al 100
    void Count()
    {   
        /*
        int i=0;
        while( i <= 100)
       {
           Debug.Log(i);
           i++;
       }
       */
       
       for(int i = 0; i <= 100; i++)
       {
           Debug.Log(ConsoleResult());
       }
    }

    int ConsoleResult()
    {   
        int i = 0;
        while( i<5)
        {
            ++i;
        }
        return i;
    }

// Ejercicio 2 ------------ Mostrar los números del 100 al 0
    void Countdown()
    {
        /*
        int i = 100;
        while (i >= 0)
        {
            Debug.Log(i);
            i--;
            
        }
        */

        for (int i=100;i>=0;i--)
        {
            Debug.Log(i);
        }
    }

// EJERCICIO 3 ------------ Mostrar los números del 1 hasta el número ingresado.
    void CountPresset()
    {
        /*
        int i = 0;
        
        while (i <= numberTop)
        {
         Debug.Log(i);
            i++;
        }
        */
        for (int i = 0; i <= numberTop; i++)
        {
            Debug.Log(i);
        }
    }

     // EJERCICIO 3 CON ARRAY
    void MiArray()
    {
        unArray = new int [cajones];
        Debug.Log("El tamaño del array son " +cajones + " números");
    }
    
    void RellenarArray()
    {
       // unArray[1] = 34;
        for (int i = 0; i < unArray.Length ; ++i)
        {
            unArray[i] = Randomice();
        }
    }

    int Randomice()
    {
        randomice = Random.Range(-100,100);
        Debug.Log(randomice);
        return randomice;
    }


// EJERCICIO 4 -----------------     introducir 10 números y mostrar los números positivos

    void NumberPositive()
    {
        Debug.Log("Los numeros POSITIVOS son: ");
        for (int i = 0; i < unArray.Length; ++i)
        {
            if(unArray[i] > 0)
            {
                Debug.Log(unArray[i]);
            }
        }
    }

// Ejercicio 5 -------------------  introducir 10 números y mostrar los números negativos

    void NumberNegative()
    {
        Debug.Log("Los numeros NEGATIVOS son: ");
        for (int i = 0; i < unArray.Length; ++i)
        {
            if(unArray[i] < 0)
            {
                Debug.Log(unArray[i]);
            }
        }

    }

// EJERCICIO 6 ------------------- Mostrar los números impares entre el 0 y el 100

     void NumberPar()
    {   
        Debug.Log("De entre los números ingresados, éstos son impares: ");
    
        for ( int i=0; i < unArray.Length; ++i)
        {
            if( unArray[i] % 2 != 0)
            {
                Debug.Log (unArray[i]);
            }
        }
    }    

// EJERCICO 7 ----------- Mostrar los números pares entre el 0 y el 100

    void NumberImpar()
    {
        Debug.Log("De entre los números ingresados, éstos son pares: ");

        for(int i=0; i < unArray.Length; ++i)
        {
            if (unArray[i] % 2 == 0)
            {
                Debug.Log(unArray[i]);
            }
        }

    }

// EJERCICIO 8 -----------   Mostrar los múltiplos de 3 desde 0 al 100

    void NumberMultiple3()
    {
        Debug.Log("Éstos son los múltiples de 3 que hay entre el 0 y el 100: ");

        for(int i=0; i < 100; ++i)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }

// Ejercicio 9 ------------- Mostrar los múltiplos de 2 y de 3 desde 0 al 100

    void NumberMultiple2_3()
    {
        Debug.Log("Éstos son los múltiples de 2 y de 3 que hay entre el 0 y el 100: ");

        for(int i=0; i < 100; ++i)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                result += i + ", ";
                
            }
        } 
        
        int indexResult = result.LastIndexOf (',', result.Length-3);
        // Debug.Log(result.Length);
        //Debug.Log(indexResult);
        //Debug.Log(result.Substring(60));

        result = result.Remove(indexResult,1);
        //Debug.Log(result.Substring(60));

        result = result.Insert(indexResult, " y");
        result = result.Substring(0, result.Length-2);
        Debug.Log(result);

    }


// Ejercicio 10 - Introducir un número y mostrar la suma de los números del 1 al número introducido.
// el número a introducir ya lo tengo con unArray.
    void SumaTotal()
    {
        int sumaArray = 0;
        for (int i=0; i <= unArray.Length; ++i)
        {
            sumaArray = unArray[i] + sumaArray;
            // sumaArray += i;   
        }
        Debug.Log("La Suma de todos los números ingresados en nuestro Array es: " + sumaArray);
    }
}
