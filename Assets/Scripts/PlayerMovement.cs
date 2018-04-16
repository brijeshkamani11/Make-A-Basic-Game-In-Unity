using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float force=500;
    public float forwordforce = 1500;
	// Use this for initialization
	
	// Update is called once per frame
	void FixedUpdate () {
         
        //Debug.Log(tf.position);
        rb.AddForce(new Vector3(-forwordforce ,0,0));   
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(0,0,force));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(0, 0, -force));
        }
       

    }
}
