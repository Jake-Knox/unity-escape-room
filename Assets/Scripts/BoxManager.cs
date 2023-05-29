using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BoxManager : MonoBehaviour
{

    private bool keyAvailable = true;

    public AudioClip winSound;
    public GameObject keyPrefab;


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
        if (col.gameObject.tag == "KeyPiece")
        {
            if (keyAvailable == true)
            {
                
                gameObject.GetComponent<AudioSource>().PlayOneShot(winSound);
                GameObject winKey = transform.Find("KeyLocation").gameObject;
                Instantiate(keyPrefab, winKey.transform.position,transform.rotation);
                Destroy(winKey);
                
                keyAvailable = false;
                col.gameObject.SendMessage("PieceUsed");

                //Debug.Log("Give Key");               
            }            
        }
    }



}
