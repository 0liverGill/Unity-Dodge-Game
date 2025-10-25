using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Vector3 pos;
    public float frequency;
    public float magnitude;
    public Rigidbody2D rb;
    public float projectileDamage;
    public Transform player;
    public float speed;
    public float arcSpeed;
    private float maxDistance = 40;

    protected virtual void Remove() //removes projectiles when certain distance from player
    {
        if (maxDistance < Vector2.Distance(transform.position, player.position))   
        {
            GlobalStorage.projectileCount = GlobalStorage.projectileCount - 1;
            Destroy(gameObject);
        }
    }

    protected virtual void PointToPlayer()
    {
       
        Vector3 direction = (player.position - transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x);
        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg -90);
    }
    
    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
      //when collides with player 
      if (collision.gameObject.tag == "Player")
      {
        GlobalStorage.Health = GlobalStorage.Health - projectileDamage; //reduce health
        Destroy(gameObject);                                            //destroy the object
        GlobalStorage.projectileCount = GlobalStorage.projectileCount - 1; //reduce projectile count (see What_Spawn)
        Debug.Log(GlobalStorage.Health);
        Debug.Log(GlobalStorage.projectileCount);
      }
    }
    
    protected virtual void Line()
    {
        rb.velocity = transform.up * speed;
    }
    protected virtual void Arc()
    {
        rb.angularVelocity = arcSpeed;
        rb.velocity = transform.up * speed;
    }
    protected virtual void Wave()
    {
        pos += transform.up * Time.deltaTime * speed;
        transform.position = pos + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
    }
    protected virtual void Start()
    {
        pos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    protected virtual void Update() //called every frame
    {
        Remove();

    }
}













//(player.position - transform.position);
//PointToPlayer();
//rb = GetComponent<Rigidbody2D>();