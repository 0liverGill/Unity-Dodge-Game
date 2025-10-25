using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class What_Spawn : MonoBehaviour
{
    public Where_Spawn Where_Spawn;
    private int[] pTable = new int[4];               //will hold all the probabilities for each projectile
    List<GameObject> spawnTable = new List<GameObject>();    //will hold the gameobjects that could be spawned GameObject
    public int totalProbability;                      //holds the total probabilty so that percentage can be used
    public int rProbability;                         //will contain the random number that decides what object spawns
    public GameObject Ball_Prefab;
    public GameObject Arrow_Prefab;
    public GameObject Star_Prefab;
    public GameObject Homing_Prefab;

    public void Start()
    {
        GlobalStorage.projectileCount = 0;

    }
    public void Update()
    {
               
        Debug.Log(rProbability);
        if (GlobalStorage.projectileCount < GlobalStorage.projectileMax) //checks if there arent enough projectiles
        {
           
            // adds probabiltiy of each projectile object to a list
            pTable[0] = GlobalStorage.pArrow;
            pTable[1] = GlobalStorage.pBall;
            pTable[2] = GlobalStorage.pStar;
            pTable[3] = GlobalStorage.pHoming;
            // sorts the list high to low
            Array.Sort(pTable);
            Array.Reverse(pTable);
            // sums each probabiltiy in list
            totalProbability = 0;               ////new line sr.ktgbw;ogbw;togbw;iogb;iogb changed 
            foreach (var item in pTable)
            {
                totalProbability += item;
            }
            rProbability = UnityEngine.Random.Range(0, totalProbability);
            //checks which projectile to spawn based on the rProbability
            
            for (int i = 0; i < pTable.Length; i++)
            {
                if (rProbability <= pTable[i])
                {

                    if (pTable[i] == GlobalStorage.pArrow)      
                    {                                            
                        spawnTable.Add(Arrow_Prefab); 
                        //spawnTable.Add("Arrow");
                    }
                    if (pTable[i] == GlobalStorage.pBall)
                    {                    
                        spawnTable.Add(Ball_Prefab); 
                        //spawnTable.Add("Ball");
                    }
                    if (pTable[i] == GlobalStorage.pStar)
                    {                       
                        spawnTable.Add(Star_Prefab); 
                        //spawnTable.Add("Star");
                    }
                    if (pTable[i] == GlobalStorage.pHoming)
                    {
                        spawnTable.Add(Homing_Prefab);
                        //spawnTable.Add("Star");
                    }
                    //chooses random object in the list of possible objects and spawns it.
                    int rItem = UnityEngine.Random.Range(0, spawnTable.Count);        
                    
                    Where_Spawn.Spawn(spawnTable[rItem]);
                   /// Debug.Log(spawnTable[rItem]);
                    spawnTable.Clear();               //clears the list so it can be reused next frame                   
                    GlobalStorage.projectileCount = GlobalStorage.projectileCount + 1;//increments projectile count as there are more projectiles on screen
                    return;
                    
                }
                else
                {
                    rProbability -= pTable[i];

                }
            }
        }
    }
}





// adds to a list at end of if statment then picks a random one from list and spawns it.


