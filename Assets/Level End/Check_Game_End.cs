using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //allows script to modify scenes


public class Check_Game_End : MonoBehaviour
{
    public int gameState;

    void Start()
    {
        gameState = SceneManager.GetActiveScene().buildIndex;
        Save_Level.lastGamestate = gameState;   //links to Save_Level holds the current gamestate forver
    }
    void Update()
    {     
        if (GlobalStorage.Health <= 0)
        {
            if (gameState == 5)  //if currently on endless mode
            {
                SceneManager.LoadScene(sceneBuildIndex:9);  //loads endless end
            }
            else
            {
                SceneManager.LoadScene(sceneBuildIndex:8);  //loads level lose
            }
        }
        else
        {          
            if (GlobalStorage.Time == 0)
            {
                SceneManager.LoadScene(sceneBuildIndex: 7); //loads level win
            }
        }
    }
}

