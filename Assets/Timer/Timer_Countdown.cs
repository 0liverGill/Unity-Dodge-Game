using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Timer_Countdown : MonoBehaviour
{

    public float Start_Time;
    
    public Text Timer_Text;
 
    void Start()
    {
        GlobalStorage.Time = Start_Time;           
    } 
    void Update()
    {
        GlobalStorage.Time -= 1 * Time.deltaTime;       //reduces time by 1, each second
        Timer_Text.text = GlobalStorage.Time.ToString("F0");    //converts time into string to display
        

        if (GlobalStorage.Time <= 0)
        {
            GlobalStorage.Time = 0;    //this code means time never goes below 0

        }
        
    }
}































//Timer_Text.color = Color.yellow;