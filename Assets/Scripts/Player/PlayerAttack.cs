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

    // Start is called before the first frame update
    void Start()
    {
        shadow = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        InputMouse();
        InputKey();
        InputPad();
    }
    // ---------------------- INPUTS ---------------------

    void InputKey()
    {

    }

    void InputMouse()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CollisionOff();
            Invoke("CollisionOn",shadowtime);
            Attack();
            
        }
    }

    void InputPad()
    {

    }

// ---------------------- MÉTODOS ---------------------

    void Attack()
    {
        GameObject cloneball = Instantiate(ballPrefab, SpawnBall.position, SpawnBall.rotation);
        cloneball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,directionY,directionZ) * Force);  
    }

// ---------------------- DEACTIVATE COLLISION ---------------------

     void CollisionOff()
    {    
        shadow.enabled = false ;
    }

    void CollisionOn()
    {
        shadow.enabled = true ;
    }

}
