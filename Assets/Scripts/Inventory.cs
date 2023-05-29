using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public static int keys = 0;

    public AudioClip collectSound;



    // Start is called before the first frame update
    void Start()
    {
        keys = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CellPickup()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        keys++;
    }


}
