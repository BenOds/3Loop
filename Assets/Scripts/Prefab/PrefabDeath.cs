using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDeath : MonoBehaviour
{
    GameObject player;
    PlayerAttack playerattack;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerattack = player.GetComponent<PlayerAttack>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            playerattack.count++;
            playerattack.Renaming();
            Destroy(gameObject);
            
        }
    }
}
