using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Menu : MonoBehaviour
{    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);   //changes scene to menu
        }
    }
}

