using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point_At_Player : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    public void Point()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 direction = (target.position - transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x); 
        transform.rotation = Quaternion.Euler(0f, 0f, angle * Mathf.Rad2Deg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


