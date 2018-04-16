using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text Scoretext;
    private float var1, var,currentx;
    void Start()
    {
        currentx = player.position.x;
    }
	// Update is called once per frame
	void FixedUpdate() { 
        var1=player.position.x;
        var =  - var1+currentx;
        Scoretext.text = var.ToString("0");
	}
}
