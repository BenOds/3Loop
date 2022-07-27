using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public Rigidbody rb2;
    Light _light;

    public int speed;

    void Start()
    {
        rb2 = rb2.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * v);
        transform.Rotate(Vector3.up * speed * Time.deltaTime * h);
    }

    

}
