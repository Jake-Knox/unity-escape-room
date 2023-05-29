using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrabScript : MonoBehaviour
{

    [SerializeField]
    private Camera characterCamera;

    [SerializeField]
    private Transform slot;

    private PickableObject pickedObject;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(pickedObject)
            {
                DropItem(pickedObject);
            }
            else
            {
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 2f))
                {
                    // Check if object is pickable
                    var pickable = hit.transform.GetComponent<PickableObject>();
                    // If object has PickableItem class
                    if (pickable)
                    {
                        // Pick it
                        PickUpObject(pickable);
                    }
                }
            }
        }
    }

    private void PickUpObject(PickableObject pickableObj)
    {
        pickedObject = pickableObj;

        pickableObj.Rb.isKinematic = true;
        pickableObj.Rb.velocity = Vector3.zero;
        pickableObj.Rb.angularVelocity = Vector3.zero;

        pickableObj.transform.SetParent(slot);

        pickableObj.transform.localPosition = Vector3.zero;
        pickableObj.transform.localEulerAngles = Vector3.zero;

    }

    private void DropItem(PickableObject heldObj)
    {
        pickedObject = null;

        heldObj.transform.SetParent(null);

        heldObj.Rb.isKinematic = false;

        heldObj.Rb.AddForce(heldObj.transform.forward * 2, ForceMode.VelocityChange);

    }
}
