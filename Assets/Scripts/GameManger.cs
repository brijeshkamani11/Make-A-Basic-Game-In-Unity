using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour {
    private bool gmstate =false;
    public Score sc;
	// Use this for initialization
	public void Endgame()
    {
        if(!gmstate)
        {
            gmstate = true;
        //    FindObjectOfType<Canvas>(
            Invoke("Restart", 2);
        }
        
        
    }
    public void Restart()
    {   
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
