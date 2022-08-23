using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
// -------------- MIS VARIABLES GLOBALES ------------
    float v;
    float h;

    float delta;

    [Header("Movement")]
    public int speed;
    public int rotateSpeed;

    public int jump;

    public bool suelo;

    bool rbGravity;
    Vector3 rbVelocity;

    Rigidbody rig ;



// -------------- Inicializers ---------------------

    void Awake()
    {
        // GetComponent<Rigidbody>().useGravity = false;
        // rig = GetComponent<Rigidbody>();
        AssignmentsAwake();
    }

    void Start()
    {
        AssignmentsStart();
    }

    void Update()
    {
        Movement();
        Jump();
        Respawn();
    }

// ----------------------- Assignments ---------------

    void AssignmentsAwake()
    {
        delta = Time.deltaTime;
        rig = GetComponent<Rigidbody>();
        rbGravity = GetComponent<Rigidbody>().useGravity;
        rbVelocity = GetComponent<Rigidbody>().velocity;

    }

    void AssignmentsStart()
    {

    }

// ---------------------- MÉTODOS ---------------------

    void OnCollisionStay (Collision CollisionFloor)
        {
            suelo = true;
            Debug.Log("tocando suelo");
        }

    void Movement()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            transform.Translate(Vector3.forward * delta * v * speed);
            //transform.Translate(Vector3.back *Time.deltaTime*v*speed);

            transform.Rotate(Vector3.up * delta * h * rotateSpeed);
            //transform.Rotate(Vector3.down *Time.deltaTime*v*speed);
        }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && (suelo == true))
        {
            rig.AddForce (new Vector3 (0,9,0) * jump);
            Debug.Log("jump");
            Invoke("Suelo", 0.01f);
        }
    }

    void Respawn()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            rig.useGravity = false;
            transform.position = new Vector3(0,1,0);
            //rbBool = true;
            rig.velocity = new Vector3 (0,0,0);
            Gravity();
        }
    }

    void Suelo()
    {
        suelo = false;
    }

    void Gravity()
    {
        rig.useGravity = true;
    }

  


   
}
