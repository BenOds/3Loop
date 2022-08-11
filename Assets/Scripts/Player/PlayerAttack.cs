using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    
    [Header("GameObjects Assignments")]
    public GameObject ballPrefab;
    public Transform SpawnBall;


    BoxCollider shadow;

    [Header("Colission off gate")]
    public float shadowtime;
    bool touching;


    [Header("Direction Force")]
    public int Force;
    public float directionZ;
    public float directionY;

    [Header("Ammo")]
    public int balls;
    int reload;
    string[] ammo;

    public int count;
    GameObject cloneball;
    GameObject ballborn;
    

// -------------- Inicializers ---------------------

    void Start()
    {
        count = balls;
        string[] ammo = new string [6];
    }

    void Update()
    {
        InputMouse();
        InputKey();
        InputPad();
        
    }
// ---------------------- INPUTS ---------------------

    void InputKey()
    {
        Reload();
        AmmoCheck();
    }

    void InputMouse()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
            Invoke("TagChange",shadowtime);
        }
        
    }

    void InputPad()
    {

    }

// ---------------------- MÉTODOS ---------------------
 
    void Attack()
    {
        if (balls > 0)
        {
        cloneball = Instantiate(ballPrefab, SpawnBall.position, SpawnBall.rotation);
        cloneball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,directionY,directionZ) * Force);  
        balls--;
        count--;
        } 
    }

// ---------------------- DEACTIVATE COLLISION ---------------------


// ---------------------- AMMO ---------------------

    // Recoger bala
    void OnCollisionEnter (Collision CollisionBullet)
    {

        if(CollisionBullet.collider.CompareTag("Ball"))
        {
            touching = true;
            Debug.Log("Recogiendo bala");

        }


    }

    // Naming balas
    void Ammo()
    {
        string bullet1 = "Dum Dum nº1";
        string bullet2 = "Dum Dum nº2";
        string bullet3 = "Dum Dum nº3";
        string bullet4 = "Dum Dum nº4";
        string bullet5 = "Dum Dum nº5";
        string bullet6 = "Dum Dum nº6";

        ammo[0] = "Dum Dum nº1";
        ammo[1] = bullet2;
        ammo[2] = bullet3;
        ammo[3] = bullet4;
        ammo[4] = bullet5;
        ammo[5] = bullet6;      
    }


    void Naming()
    {
        string name;
        name = ammo[0];
        
    cloneball.name = name;

    }
 
    void AmmoCheck()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(ammo[0]);
        }
    }

    public void Reload()
    {
      
            if (Input.GetKeyDown(KeyCode.R))
        {
            balls = count;
        }
    }

    void TagChange()
    {
        ballborn = GameObject.FindGameObjectWithTag("BallBorn");
        ballborn.GetComponent<SphereCollider>().enabled = true;
        ballborn.tag = "Ball";
        
        Debug.Log("nariz disparada");
    }

}
