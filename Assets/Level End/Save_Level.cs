using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Save_Level : MonoBehaviour
{
    string path;                        //holds whatever path is needed,.
    int fileNumber;                     
    public static int lastGamestate = 1;          //holds last level gamestate
    

    public void Start()
    {
        //these statements decide what file to save to (based on level you did)
        if (lastGamestate == 1)
        {
            path = "Level1_Scores.txt";
        }
        if (lastGamestate == 2)
        {
            path = "Level2_Scores.txt";
        }
        if (lastGamestate == 3)
        {
            path = "Level3_Scores.txt";
        }
        if (lastGamestate == 4)
        {
            path = "Level4_Scores.txt";
        }     

        StreamReader reader = new StreamReader(path);   //opens file specified in path  
        string fileContent = reader.ReadToEnd();    //makes a string of the files content
        reader.Close();
        if (fileContent != "")
        {
        fileNumber = int.Parse(fileContent);    //changes fileNumber to an int so it can be compared
        }
        else                   //if there is nothing in the file
        {
            fileNumber = 0;

        }
        
        
        //selection statment for when score needs to be replaced
        if (GlobalStorage.Health > fileNumber)
        {            
            System.IO.File.WriteAllText(path, "");  //writes nothing in the new file
            string newScore = GlobalStorage.Health.ToString();
            File.WriteAllText(path, newScore);      //writes the new score in the file           
        }

    }
    


}  