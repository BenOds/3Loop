using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material mat, mat2, mat3;

    int live = 10;

    public SpawnCapsule rebirth;

    Material accessMesh;

    SpawnCapsule spawnCapsule;

    void Awake()
    {
        AccessMesh();
    }

    void Start()
    {
        // spawnCapsule = rebirth.GetComponent<SpawnCapsule>();
       // accessMesh = new Material (GetComponent<MeshRenderer>().material);
    }

    void AccessMesh()
    {
        accessMesh = new Material (GetComponent<MeshRenderer>().material);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ball"))
        {
            live --;
        }
        
        if(live >= 7)
        {
           accessMesh = mat;
        }
        else if ( live >= 4)
        {
            accessMesh = mat2;
        }
        else if (live >= 2)
        {
            accessMesh = mat3;
        }
        else if (live >=0)
        {

            AccesScript();
            Destroy(gameObject);

        }
    }

    void AccesScript()
    {
            GameObject rebirth = GameObject.Find("SpawnEnemy");
            spawnCapsule = rebirth.GetComponent<SpawnCapsule>();
            spawnCapsule.PositionSpawn();
    }

    
}
