using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time = 5;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        // timer+= Time.deltaTime;    

        if(timer > 5)
        {
            Debug.Log("Dispara");
            timer = 0; // resetear el timer
        }
    }
}
