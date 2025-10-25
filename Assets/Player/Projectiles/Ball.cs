using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Projectile
{
    protected override void Start()
    {
        arcSpeed = 3;
        speed = 5;
        base.Start();
        PointToPlayer();
        
    }
    protected override void Update()
    {
        Arc();
        base.Update();

    }
}


