using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissiles : MonoBehaviour
{
    //defining varibles 

    public Transform target;
    public float speed = 5f;
    public float turnspeed = 5000f;
    private Rigidbody2D rb;
    private bool Homing;
    
    private float angle;
    private float distance = 5f;
    // defining the target
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        Homing = true;

        


    }

    // finds direction 
    void FixedUpdate()
    {
        if (Homing == true)
        {
            
            if (Vector2.Distance(transform.position, target.position) > distance)    // if distance from object is greater than set distance
            {



                Vector2 direction = (Vector2)target.position - rb.position;

                direction.Normalize();

                float angle = Vector3.Cross(direction, transform.up).z;

                

                rb.angularVelocity = -angle * turnspeed;

                rb.velocity = transform.up * speed;


            }
            else
            {
                Homing = false;

            }


        }

        if (Homing == false)
        {
            rb.angularVelocity = 0;
            rb.velocity = transform.up * speed;

        }
        



    }
}
