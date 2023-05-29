using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndGame : MonoBehaviour
{

    public GameObject player;
    public Camera playerCamera;
    public Camera endScreenCamera;
    public Text textTimer;
    public Text textHints;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            ScoreScreen();
        }
    }
    void ScoreScreen()
    {
        player.GetComponent<AudioSource>().enabled = false;
        playerCamera.enabled = false;
        endScreenCamera.enabled = true;

        textTimer.SendMessage("timerOff");

        //textHints.rectTransform.anchorMax = 0.5f;
        textHints.rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        textHints.rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        textHints.rectTransform.pivot = new Vector2(0.5f, 0.5f);
        textHints.SendMessage("StopTimer");


        textHints.SendMessage("ShowHint", "Congratultions! 60 Seconds \n \n Great! 150 Seconds \n \n Okay 300 Seconds - Try Harder");


    }







}
