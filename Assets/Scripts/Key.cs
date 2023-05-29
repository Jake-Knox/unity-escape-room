using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public float rotationSpeed = 75.0f;
    public float moveDY = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotationSpeed * Time.deltaTime, 0));
        transform.Translate(new Vector3(0, moveDY * Time.deltaTime, 0));

        if(transform.position.y > 1.9)
        {
            moveDY = -moveDY;
        }
        else if (transform.position.y < 1.2)
        {
            moveDY = -moveDY;

        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.SendMessage("CellPickup");
            Destroy(gameObject);
        }
    }



}
