using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDeath : MonoBehaviour
{
    GameObject player;
    PlayerAttack playerattack;

    Rigidbody rb;
    public bool damage;

    ChangeMaterial health;
    GameObject enemy;

    GameObject parent;
    Transform child;

    bool controlName;

    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerattack = player.GetComponent<PlayerAttack>();
        rb = GetComponent<Rigidbody>();

        damage = true;
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        health = enemy.GetComponent<ChangeMaterial>();

        parent = GameObject.FindGameObjectWithTag("BallParent");

        // controlName = false;
        
        CheckingChild();

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

        if(collision.collider.CompareTag("Floor"))
        {
            damage = false;
            Debug.Log("Ya no hago daño");
        }

        if(collision.collider.CompareTag("Enemy") && damage == true)
        {
            health.live--;
        }
    }

    void CheckingChild()
    {
        gameObject.transform.SetParent(parent.transform,true);
    }



}
