using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NúmeroMayor : MonoBehaviour
{

    // cuál de los tres valores es mayor
    // AsignMayor

    int numberOne;
    int numberTwo;
    int numberThree;

    string nMayor = "El numero mayor es ";
    
    void Start()
    {
        numberOne = Randomice();
        numberTwo = Randomice();
        numberThree = Randomice();

        Debug.Log(Randomice());
        Debug.Log("El primer número es " +numberOne);
        Debug.Log("El segundo número es " +numberTwo);
        Debug.Log("El tercer número es " +numberThree);
        AsignMayor();
         }

    void Update()
    {
        
    }

    void AsignMayor()
    {
        if((numberOne>numberTwo) && (numberOne>numberThree))
        {
            Debug.Log (nMayor +numberOne);
        }
        else if ((numberTwo>numberOne) && (numberTwo>numberThree))
        {
            Debug.Log (nMayor +numberTwo);
        }
        else
        {
            Debug.Log (nMayor +numberThree);
        }
    }

    int Randomice()
    {
        int randomice = Random.Range(0,100);
        return randomice; 
    }
}
