using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{

    bool doorIsOpen = false;
    float doorTimer = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;



    // Start is called before the first frame update
    void Start()
    {
        doorTimer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(doorIsOpen)
        {
            doorTimer += Time.deltaTime;

            //Debug.Log("open");

            if (doorTimer > doorOpenTime)
            {
                Door(doorShutSound, false);
                doorTimer = 0.0f;
            }
            else
            {
                Destroy(gameObject);

                //open door   

                //if(transform.position.y >= 0 && transform.position.y < 5)
                //if (transform.position.y >= -7.5f && transform.position.y < 7.5f)
                //{
                //transform.Translate(new Vector3(0, 3f * Time.deltaTime, 0));
                //}
                //else if (transform.position.y > 7.5f)
                //{
                //transform.position.Set(transform.position.x, 7.5f, transform.position.z);
                //Debug.Log("should be set");

                //}
                //Debug.Log(transform.position.y);

            }

        }
        else
        {
            //shut door

            //if (transform.position.y <= 5 && transform.position.y > 0)
            //if (transform.position.y <= 7.5f && transform.position.y > -7.5f)
            //{
                //transform.Translate(new Vector3(0, -3f * Time.deltaTime, 0));
            //}
            //else if(transform.position.y < -7.5f)
            //{
                //transform.position.Set(transform.position.x, -7.5f, transform.position.z);
                //Debug.Log("should be set");
            //}
            //Debug.Log(transform.position.y);

        }



    }

    void DoorCheck()
    {
        if(!doorIsOpen)
        {
            Door(doorOpenSound, true);
        }
    }

    void Door(AudioClip aClip, bool openCheck)
    {

        AudioSource.PlayClipAtPoint(aClip, transform.position);
        //GetComponent<AudioSource>().PlayOneShot(aClip);
        doorIsOpen = openCheck;

    }







}
