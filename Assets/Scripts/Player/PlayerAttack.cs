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

    [Header("Direction Force")]
    public int Force;
    public float directionZ;
    public float directionY;

    [Header("Ammo")]
    public int balls;
    public int count;
    int reload;
    public string[] ammo;

    string rename;
    

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
        Erase();
        } 
    }

// ---------------------- AMMO ---------------------

    // Recoger bala
    void OnCollisionEnter (Collision collisionBullet)
    {
        if(collisionBullet.collider.CompareTag("Ball"))
        {
            rename = collisionBullet.gameObject.name;
            Debug.Log("Recogiendo bala "+ rename);
        }
    }

    // Naming balas
    void Ammo()
    {
        ammo[0] = "Sherif";
        ammo[1] = "Tabern";
        ammo[2] = "Train Driver";
        ammo[3] = "Gold Miner";
        ammo[4] = "Indian";
        ammo[5] = "Mexican";            
    }

    void Naming()
    {
        cloneball.name = ammo[balls-1];
    }
    public void Renaming()
    {
        int counting = balls+count-1;
        ammo[counting] = rename;
    }

    void Erase()
    {
        ammo[balls] = "";
    }
 
    void AmmoCheck()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {   
            if (balls > 0)
            {
                for(int i = (balls-1); i >= 0 ; i--)
                {
                Debug.Log(ammo[i]);
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
