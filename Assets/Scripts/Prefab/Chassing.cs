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
        chassingBoolean = false;
        player = GameObject.FindGameObjectWithTag("Player"); 
        Invoke("ChassingBoolean", chassingTime);
    }

    void Update()
    {
        PositionPlayer();
        // transform.LookAt(player.transform);
        ChassingPlayer();
        PositionNouseCheck();
    }

    void ChassingPlayer()
    {   
        if( chassingBoolean == true)
        {
            // rb.velocity = new Vector3(0,0,0);
            transform.Translate(direction * speed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(positionNouse, positionPlayer, 
                            speed * Time.deltaTime);
        }
    }

    void ChassingBoolean()
    {
        chassingBoolean = true;
    }

    void PositionPlayer()
    {
        positionPlayer = player.transform.position;
        // direction = positionPlayer - transform.position;
    }

    void PositionNouseCheck()
    {
        positionNouse = transform.position;
    }
}