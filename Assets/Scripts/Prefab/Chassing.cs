using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chassing : MonoBehaviour
{
    GameObject player;
    public Vector3 positionPlayer;
    Vector3 positionNose;


    Vector3 direction;
    public float speed;

    bool chasingBoolean;
    public int chasingTime;
    RigidBody rb;

    void Start()
    {
        rb = GetComponent<RigidBody>();
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    void Update()
    {
        PositionPlayer();
        ChasingPlayer();
        PositionNoseCheck();
    }

    void ChasingPlayer()
    {   
        if( Input.GetKeyDown(KeyCode.F))
        {
            chasingBoolean = true;
        }

        if (chasingBoolean == true)
        {
            transform.position = Vector3.MoveTowards(positionNose, positionPlayer, 
                                    speed * Time.deltaTime);
        }
    }

    void PositionPlayer()
    {
        positionPlayer = player.transform.position;
    }

    void PositionNoseCheck()
    {
        positionNose = transform.position;
    }
}