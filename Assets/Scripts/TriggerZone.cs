using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TriggerZone : MonoBehaviour
{
    public int keysNeeded = 1;

    public AudioClip lockedSound;
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
            if (Inventory.keys == keysNeeded)
            {
                try
                {
                    transform.Find("Door").SendMessage("DoorCheck");
                }
                catch
                {

                }
            }
            else if(Inventory.keys == 3)
            {
                transform.Find("Door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                textHints.SendMessage("ShowHint", "Where is my KEY?");
            }
            else if (Inventory.keys == 2)
            {
                transform.Find("Door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                textHints.SendMessage("ShowHint", "I wonder where my old alarm clock is...");
            }
            else if (Inventory.keys == 1)
            {
                transform.Find("Door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                textHints.SendMessage("ShowHint", "I need to clean out my old food...");
            }
            else
            {
                transform.Find("Door").GetComponent<AudioSource>().PlayOneShot(lockedSound);
                textHints.SendMessage("ShowHint", "I want to reorganise my bookshelf...");
            }
        }
     }


}
