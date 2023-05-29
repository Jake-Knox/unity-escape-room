using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PickableObject : MonoBehaviour
{
    //Allowing the player to pick up this object

    private Rigidbody rb;
    public Rigidbody Rb => rb;

    private void Awake()
    {
        // Get reference to the rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PieceUsed()
    {
        transform.gameObject.tag = "Untagged";
    }


}
