using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioRepaso : MonoBehaviour
{
    public float speed;
    public GameObject torch;

    public float rangeXmin;
    public float rangeXmax ;
    public float rangeZmin;
    public float rangeZmax;
    void Start()
    {
        
    }

    void Update()
    {
        Teleport();
        MoveForward();
        EnableTorch();
    }

    void EnableTorch()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (torch.activeInHierarchy == true)
            {
                torch.SetActive(false);
            }
            else
            {
                torch.SetActive(true);
            }
        }
    }
    void MoveForward()
    {
        transform.Translate(0,0,Speed());
    }
    float Speed()
    {
        float metersXsecond;
        metersXsecond = speed * Time.deltaTime;
        return metersXsecond;
    }

    void Teleport()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            transform.position = Randomice();
        }
    }

    Vector3 Randomice()
    {
        float rangeX = Random.Range(rangeXmin,rangeXmax);
        float rangeZ = Random.Range(rangeZmin,rangeZmax);
        Debug.Log("Posición eje X = "+rangeX);
        Debug.Log("Posición eje z = "+rangeZ);
        Vector3 newPosition = new Vector3(rangeX,0,rangeZ);

        return newPosition;
    }
    
}
