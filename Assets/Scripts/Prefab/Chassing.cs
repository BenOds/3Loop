using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chassing : MonoBehaviour
{
    GameObject player;
    public Vector3 positionPlayer;
    Vector3 positionNouse;


    Vector3 direction;
    public float speed;

    bool chassingBoolean;
    public int chassingTime;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    void Update()
    {
        PositionPlayer();
        ChassingPlayer();
        PositionNouseCheck();
    }

    void ChassingPlayer()
    {   
        if( Input.GetKeyDown(KeyCode.F))
        {
            chassingBoolean = true;
        }

        if (chassingBoolean == true)
        {
            transform.position = Vector3.MoveTowards(positionNouse, positionPlayer, 
                                    speed * Time.deltaTime);
        }
    }

    void PositionPlayer()
    {
        positionPlayer = player.transform.position;
    }

    void PositionNouseCheck()
    {
        positionNouse = transform.position;
    }
}