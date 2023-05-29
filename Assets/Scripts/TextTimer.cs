using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimer : MonoBehaviour
{

    public int timerStart = 1;
    public int timerDifference = 1;
    public static int time = 0;

    public bool timerOn = true;



    // Start is called before the first frame update
    void Start()
    {        
        InvokeRepeating("UpdateTimerText", timerStart, timerDifference);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTimerText()
    {
        if(timerOn == true)
        {
            gameObject.GetComponent<Text>().enabled = true;
            time++;


            string message = ("TIME: " + time.ToString());
            gameObject.GetComponent<Text>().text = message;
        }
        else
        {
            string message = ("Score: " + time.ToString() + " Seconds!");
            gameObject.GetComponent<Text>().text = message;
        }



    }

    public void timerOff()
    {
        timerOn = false;
    }


}
