using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : Projectile
{
    protected override void Start()
    {
        speed = 5f;
        base.Start();
        PointToPlayer();
        

    }
    protected override void Update()
    {
        Line();
        base.Update();

    }
}
