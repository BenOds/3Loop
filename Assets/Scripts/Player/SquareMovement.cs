using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
// -------------- MIS VARIABLES GLOBALES ------------
    float v;
    float h;

    float delta;

    [Header("GameObjects Assignments")]
    public GameObject ballPrefab;
    public Transform SpawnBall;

    [Header("Force")]
    public int Force;
    public float directionZ;
    public float directionY;

    [Header("Movement")]
    public int speed;
    public int rotateSpeed;


// -------------- Inicializers ---------------------
    void Awake()
    {
        Assignments();
    }

    void Start()
    {

    }

    void Update()
    {
        Movement();
        InputMouse();
        InputKey();
        InputPad();
    }
// ----------------------- Assignments ---------------

    void Assignments()
    {
        delta = Time.deltaTime;
    }


// ---------------------- INPUTS ---------------------

    void InputKey()
    {

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
    void Movement()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * delta * v * speed);
        //transform.Translate(Vector3.back *Time.deltaTime*v*speed);

        transform.Rotate(Vector3.up * delta * h * rotateSpeed);
        //transform.Rotate(Vector3.down *Time.deltaTime*v*speed);
    }

    void Attack()
    {
        GameObject cloneball = Instantiate(ballPrefab, SpawnBall.position, SpawnBall.rotation);
        cloneball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0,directionY,directionZ) * Force);
        
    }
   
}
