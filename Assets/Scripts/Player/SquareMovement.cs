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

    bool suelo;


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
        Jump();

    }

// ----------------------- Assignments ---------------

    void Assignments()
    {
        delta = Time.deltaTime;
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

        void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && (suelo = true))
        {
            Rigidbody rig = GetComponent<Rigidbody>();
            rig.AddForce (new Vector3 (0,9,0) * jump);
            Debug.Log("jump");
        }
    }

    void OnCollisionStay (Collision CollisionFloor)
    {

        if(CollisionFloor.collider.CompareTag("Floor"))
        {
            suelo = true;
            Debug.Log("tocando suelo");

        }
        else
        {   
            suelo = false;
            Debug.Log("No toco suelo");
        }

    }


   
}
