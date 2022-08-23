using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDeath : MonoBehaviour
{
    GameObject player;
    PlayerAttack playerattack;

    Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerattack = player.GetComponent<PlayerAttack>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            rb.velocity = new Vector3 (0,0,0);
            playerattack.count++;
            playerattack.Renaming();
            Destroy(gameObject);
            
        }
    }
}
