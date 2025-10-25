using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;


public class Display_Level_Score : MonoBehaviour
{
    private string path;
    public int level;           //holds the level the textobject is associated with
    public Text levelScoreDisplay;
    
    void Start()
    {
        //statement decides which file to read from
        if (level == 1)
        {
            path = "Level1_Scores.txt";
        }
        if (level == 2)
        {
            path = "Level2_Scores.txt";
        }
        if (level == 3)
        {
            path = "Level3_Scores.txt";
        }
        if (level == 4)
        {
            path = "Level4_Scores.txt";
        }

        StreamReader reader = new StreamReader(path);   //opens file specified in path  
        string fileContent = reader.ReadToEnd();
        reader.Close();

        levelScoreDisplay.text = fileContent;      //turns the text in the text object into the string from file
    }

   
}
