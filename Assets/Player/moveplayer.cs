using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    public float moveSpeed = 5f;    //controls how fats player moves

    public Rigidbody2D rb;

    Vector2 movement;
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");    //controls x axis 
        movement.y = Input.GetAxisRaw("Vertical");      //controls y axis 
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);  //moves player by movement vector
    }

}

