using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Where_Spawn : MonoBehaviour
{
    private int[] xLocation = { 193, 193, 243, 243 };   //stores x location of each spawn
    private int[] yLocation = { 159, 181, 181, 159 };   //stores y location
    private int rSpawn;                                 //holds a random number that determins where it spawns
   
    
    public void Spawn(GameObject missile)
    {
        //spawns the object then moves it to 1 of the 4 random locatios based on rSpawn
        //spawns anywhere
        if (GlobalStorage.directionSpawn == 1)
        {
            rSpawn = Random.Range(0, 3);
            Instantiate(missile);          
            missile.transform.position = new Vector3(xLocation[rSpawn], yLocation[rSpawn], 1);  
        }
        //spawns on the right
        if (GlobalStorage.directionSpawn == 2)
        {
            rSpawn = Random.Range(2, 3);
            Instantiate(missile);          
            missile.transform.position = new Vector3(xLocation[rSpawn], yLocation[rSpawn], 1);
        }
        //spawns on the left
        if (GlobalStorage.directionSpawn == 3)
        {
            rSpawn = Random.Range(0, 1);
            Instantiate(missile);            
            missile.transform.position = new Vector3(xLocation[rSpawn], yLocation[rSpawn], 1);
        }
    }
    
}








//missile.transform.position = new vect
//Instantiate(missile, transform.position.location[Random.Range(0, 3)], Random.rotation);
//Instantiate(missile, transform.position.location[Random.Range(0, 3)], Random.rotation);
//missile.transform.position = new Vector3(x, y, z);
//Instantiate(missile, transform.position.location[Random.Range(0, 3)], Random.rotation);
//missile.transform.position = new Vector3(x, y, z);