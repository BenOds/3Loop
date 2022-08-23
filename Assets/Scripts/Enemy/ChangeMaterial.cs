using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material mat, mat2, mat3;

    public int live = 10;
    GameObject ball;

    // bool damage = false;

    Renderer accessMesh;

    SpawnCapsule spawnCapsule;

    void Awake()
    {
        AccessMesh();
        AccesScript();

    }

    void Start()
    {
        
    }

    void Update()
    {
        CheckLife();
    }

    void AccessMesh()
    {
        accessMesh = GetComponent<MeshRenderer>();
    }
    


    void CheckLife()
    {
        if(live >= 7)
        {
           accessMesh.material = new Material (mat);
           Debug.Log("Color VERDE");
        }
        else if ( live >= 4)
        {
           accessMesh.material = new Material (mat2);
           Debug.Log("Color AMARILLO");

        }
        else if (live >= 2)
        {
           accessMesh.material = new Material (mat3);
           Debug.Log("Color ROJO");

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
