using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCapsule : MonoBehaviour
{

    public GameObject spawnCapsulePrefab;
    public Transform spawnPosition;

    public Collider colliderPlayer;

    int positionX;
    int positionZ;

    void Start()
    {
        PositionSpawn();
        
    }

    void Update()
    {
        
    }

    public void PositionSpawn ()
    {
        positionX = Random.Range(-10, 10);
        positionZ = Random.Range(-10, 10);
        Debug.Log(positionX);
        Debug.Log(positionZ);
        spawnPosition.position = new Vector3(positionX, 1, positionZ);
        ControlSpawn();

    }
    void ControlSpawn()
    {
        if (positionX >= -1 && positionX <= 1 || positionZ >= -1 && positionZ <= 1)
        {
            PositionSpawn();
        }
        else
        {
           Instantiate(spawnCapsulePrefab, spawnPosition.position, spawnPosition.rotation);
        }

    }



   

    
}
