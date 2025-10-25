using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : Projectile
{
    protected override void Start()
    {
       
        base.Start();
        PointToPlayer();
    }
    protected override void Update()
    {
        Wave();
        base.Update();
    }
}





//frequency = 1;
        //magnitude = 5;
        //speed = 5;