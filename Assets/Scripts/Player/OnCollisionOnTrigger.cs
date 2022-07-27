using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionOnTrigger : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("He chocado");
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("Estoy chocado");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            Debug.Log("He salido del choque");
        }
    }
}
