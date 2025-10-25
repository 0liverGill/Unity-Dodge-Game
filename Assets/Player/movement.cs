using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private float speed = 11f;  //controls speed
    public Rigidbody2D rb;      //uses rigidbodies to transform

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }    
    void Update()
    {
        Vector2 pos = transform.position;  //holds the amount the player will transformed this frame
        
        if (Input.GetKey("w"))          //when w is pressed
        {
            pos.y += speed * Time.deltaTime;  //moves y postition of vector up by speed every second
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;    //moves y postition down
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;    //moves x position right 
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;    //moves x position left
        }

        rb.transform.position = pos;    //transforms the player to the new vector position
    }
    

}

