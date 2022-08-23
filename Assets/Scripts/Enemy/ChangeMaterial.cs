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
        AccesScript();

    }

    void Start()
    {
        // spawnCapsule = rebirth.GetComponent<SpawnCapsule>();
       // accessMesh = new Material (GetComponent<MeshRenderer>().material);
    }

    void Update()
    {
        CheckLife();
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
    }

    void CheckLife()
    {
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

            SpawnCapsule();
            Destroy(gameObject);

        }
    }

    void AccesScript()
    {
            GameObject rebirthObject = GameObject.Find("SpawnEnemy");
            spawnCapsule = rebirthObject.GetComponent<SpawnCapsule>();
    }

    void SpawnCapsule()
    {
        spawnCapsule.PositionSpawn();
    }

    
}
