using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material mat, mat2, mat3;

    int live = 10;

    public SpawnCapsule rebirth;

    Material accessMesh;

    void Awake()
    {
        AccessMesh();
    }

    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Ball"))
        {
            live --;
        }
        
        if(live >= 7)
        {
           GetComponent<MeshRenderer>().material = mat;
        }
        else if ( live >= 4)
        {
            GetComponent<MeshRenderer>().material = mat2;
        }
        else if (live >= 2)
        {
            GetComponent<MeshRenderer>().material = mat3;
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
            SpawnCapsule spawnCapsule = rebirth.GetComponent<SpawnCapsule>();
            spawnCapsule.PositionSpawn();
    }
    void AccessMesh()
    {
        accessMesh = new Material (GetComponent<MeshRenderer>().material);
    }
    
}
