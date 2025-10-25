using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock_Hand : MonoBehaviour
{
    private bool Collision;
    private int i;
    private Transform player;
    private Rigidbody2D rb;
    public float phaseTime = 10;    //controls time in different state
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }
    //code to spin the object
    void Spinning()
    {
        transform.Rotate(0, 0, -50 * Time.deltaTime);         //spins 50 degrees per second
    }
    //code to extend the object
    void Extending()
    {
              
            transform.localScale = new Vector2(2.5f, 1);          

    }
    //code to change the object back to original shape
    void Retracting()
    {
        transform.localScale = new Vector2(1, 1);  //returns the shape back to its original scale        

    }
    void Detect_Player()
    {
        if (GlobalStorage.phase == 0)
        {
            GlobalStorage.directionSpawn = 1;  //changes spawning location
            Collision = false;
            Retracting();               //resets shape to its orginal length
           
            Spinning();
            Vector2 direction = (Vector2)player.position - rb.position;
            direction.Normalize();                                     //gets angle between two objects     
            float angle = Vector3.Cross(direction, transform.up).z;
                      

            //Debug.Log(angle);
            if (angle < -0.999 ) //when pointing to player it should change "phase" i.e. its movement changes
            {
                GlobalStorage.phase = 1;
            }

        }
        if (GlobalStorage.phase == 1)           //if phase is different 
        {
            
            Extending();
            GlobalStorage.directionSpawn = 2;  //changes spawning location 
            if (phaseTime < 0)             //checks if defined time has passed 
            {
                GlobalStorage.phase = 0;   //makes the goes back to original phase
                phaseTime = 10;             //resets phase time for next loop
            }
            else
            {
                phaseTime = phaseTime - Time.deltaTime;
            }
           
        }

    }
    
    void Update()
    {
        Detect_Player();

    }
}
