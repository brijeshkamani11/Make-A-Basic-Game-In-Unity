using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public Rigidbody rb;
    public float force=500;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(tf.position);
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(-force,0,0));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(force, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(0,0,force));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(0, 0, -force));
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, force*35, 0));
        }
    }
}
