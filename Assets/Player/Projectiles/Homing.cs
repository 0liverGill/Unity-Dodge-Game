using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : Projectile
{
    

    private bool Locked = false;        //controls wheather homing is on or not

    private float ShadowDistance = 5;   //distance from player stops homing

    void Home() //algorithm to turn and move to player.
    {      
        if (ShadowDistance < Vector2.Distance(transform.position, player.position) && Locked == false)  
        {
           
            Vector3 direction = (player.position - transform.position);         //direction vector between projectile and object
            float angle = Mathf.Atan2(direction.y, direction.x);                //gets angle between them
            transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg - 90);  //turns the object by the angle 

        }
        else
        {
            Locked = true;              //if it isnt true the above if statment isnt triggered again
        }
        rb.velocity = transform.up * speed;
    }
    protected override void Start()
    {
        speed = 6f;     //sets speed
        base.Start();
        PointToPlayer();
    }
    protected override void Update()
    {
        Home();             //calls Home() every frame
        base.Update();
        
    }
   
     
    
   
   

    

}
//Vector2 direction = (Vector2)player.position - rb.position; //direction vector between projectile and object
//direction.Normalize();
//        float angle = Vector3.Cross(direction, transform.up).z; //gets cross product              
//rb.angularVelocity = -angle* turnspeed;           //changes angular velocity
//rb.velocity = transform.up* speed;         //moves fowards
