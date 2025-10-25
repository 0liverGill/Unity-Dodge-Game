using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



public class one : MonoBehaviour
{
    public string path;
    // Start is called before the first frame update
    void Start()
    {
        path = "Level3_Scores.txt";


        //string fileContent = Application.streamingAssetsPath + path;
        

        File.WriteAllText(path, "hello");

        

        StreamReader reader = new StreamReader(path);
        Debug.Log(reader.ReadToEnd());
        reader.Close();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
