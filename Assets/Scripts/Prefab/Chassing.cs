using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chassing : MonoBehaviour
{
    GameObject player;
    public Vector3 positionPlayer;

    Vector3 direction;
    public float speed;

    bool chassingBoolean;

    void Start()
    {
        chassingBoolean = false;
        player = GameObject.FindGameObjectWithTag("Player"); 
        Invoke("ChassingBoolean", 5);
    }

    void Update()
    {
        PositionPlayer();
        //transform.LookAt(player.transform);
        ChassingPlayer();
    }

    void ChassingPlayer()
    {   
        if( chassingBoolean == true)
        {
        //transform.Translate(direction * speed * Time.deltaTime);
        transform.Translate(Vector3.MoveTowards(transform.position, positionPlayer, 
                            speed * Time.deltaTime));
        }
    }

    void ChassingBoolean()
    {
        chassingBoolean = true;
    }

    void PositionPlayer()
    {
        positionPlayer = player.transform.position;
        direction = positionPlayer - transform.position;
    }
}