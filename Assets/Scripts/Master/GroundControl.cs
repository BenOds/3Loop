using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyChek();
    }

    void EnemyChek()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        if(enemy == false)
        {
            AccesScript();
        }
    }
        void AccesScript()
    {
            GameObject rebirth = GameObject.Find("SpawnEnemy");
            SpawnCapsule spawnCapsule = rebirth.GetComponent<SpawnCapsule>();
            spawnCapsule.PositionSpawn();
    }

    bool BallCheck()
    {   
        // Conseguimos Array con trodos los GO con tag Ball.
        GameObject[] ball = GameObject.FindGameObjectsWithTag("Ball");

        // Accedemos al Array para comprobar que cada GO tiene el bool False
        // Si detecta que hay uno con True, termina el bucle y no hace acción.
        // Si no encuentra True, procede a hacer acción.
        // la Acción es darle al bool True.

        // variable booleano del GO
        bool compare = GameObject.controlName;

        // Comprobamos que la variable controlName 
        // del Prefab identificado con el tag "BAll" es false o true

        if (ball < ball.maxlenght && compare == false)
            {
                for(i = 0; i >= 0 ; i++)
                {
                 
                }
            }
            else
            {
            
            }

         return ball;
    }
}
