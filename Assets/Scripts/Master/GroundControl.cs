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
}
