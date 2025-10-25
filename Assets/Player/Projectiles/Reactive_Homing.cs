using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactive_Homing : MonoBehaviour
{
    public float ShadowDistance = 5;
    public Transform target;
    private bool Locked = false;
    private Rigidbody2D rb;
    public int speed = 5;
    public Point_At_Player point_At_Player;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        point_At_Player.Point();
    }

    // Update is called once per frame
    void Update()
    {
        if (ShadowDistance > Vector2.Distance(transform.position, target.position) && Locked == false)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            Vector3 direction = (target.position - transform.position);
            float angle = Mathf.Atan2(direction.y, direction.x);
            transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);

            Locked = true;




        }

        rb.velocity = transform.up * speed;




    }

}