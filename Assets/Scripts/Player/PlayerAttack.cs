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
        count = 0;
        ammo = new string [6];
        Ammo();
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
        Naming();
        balls--;
        
        Invoke("TagChange",shadowtime);
        } 
    }

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
        ammo[0] = "Dum Dum nº1";
        ammo[1] = "Dum Dum nº2";
        ammo[2] = "Dum Dum nº3";
        ammo[3] = "Dum Dum nº4";
        ammo[4] = "Dum Dum nº5";
        ammo[5] = "Dum Dum nº6";            
    }

    void Naming()
    {
        cloneball.name = ammo[0];
        //cloneball.name = "pepe";
    }
 
    void AmmoCheck()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {   
            if (balls > 0)
            {
                for(int i = 5; i <= (balls-1) ; i--)
                {
                Debug.Log(ammo[i] +", ");
                }
            }
            else
            {
                Debug.Log("No hay narices");
            }
        }

    }

    public void Reload()
    {
      
            if (Input.GetKeyDown(KeyCode.R))
        {
            balls = count + balls;
            count = 0;
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
