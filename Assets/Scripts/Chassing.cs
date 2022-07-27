using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chassing : MonoBehaviour
{
    GameObject player;
    Vector3 positionPlayer;

    Vector3 direction;
    public float speed;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
        
       
    }

    void Update()
    {
        positionPlayer = player.transform.position;
        direction = positionPlayer - transform.position;
        //transform.LookAt(player.transform);
        Invoke("ChassingPlayer", 5);
    }

    void ChassingPlayer()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        transform.Translate(Vector3.MoveTowards(transform.position, positionPlayer, 
                            speed * Time.deltaTime));
    }
}