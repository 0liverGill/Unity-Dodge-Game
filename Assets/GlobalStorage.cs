using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStorage : MonoBehaviour
{
    public static float Health = 100;   //holds the players health 
    public static float Time = 0;       //holds the time the player is in game
    public static int pArrow = 30;      //probabilty an Arrow will spawn
    public static int pBall = 25;       //probabilty a Ball will spawn
    public static int pStar = 25;       //probabilty a Star will spawn
    public static int pHoming = 20;     //probabilty a homing projectile will spawn
    public static int projectileCount =0 ;  //holds the number of projectiles in the level
    public static int projectileMax = 8;    //holds the max number of projectiles allowed in a level 
    public static int directionSpawn = 1;   //holds the direction the projecitles will spawn 
    public static int phase = 0;            //holds the state the reactive arena is in
       
}
