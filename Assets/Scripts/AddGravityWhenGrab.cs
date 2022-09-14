using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGravityWhenGrab : MonoBehaviour
{
    GameObject grabbedObject;
    public Collider rightHandCollider;
    public Collider leftHandCollider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other == rightHandCollider || other == leftHandCollider)
        {
            grabbedObject = gameObject;
            grabbedObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
