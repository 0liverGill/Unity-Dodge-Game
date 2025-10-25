using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Bar : MonoBehaviour
{
        
    private float BHealth;
    
    private float ratio = 100;

    void Start()
    {
        GlobalStorage.Health = 100;     //resets health so levels can be repeated

    }

    // Update is called once per frame
    void Update () 
    {
        
        
        BHealth = GlobalStorage.Health;
        ratio = BHealth / 100;
        if (ratio < 0)
        {
            ratio = 0;
        }
        
        
        transform.localScale = new Vector2(ratio, 1);

        
        


    }
}















//if (ratio< 0)
//           {
//                ratio = 0;
//            }