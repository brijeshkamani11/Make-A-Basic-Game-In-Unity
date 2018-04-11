using UnityEngine;

public class Collision : MonoBehaviour {
    public Player1 off;
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            off.enabled = false;
        }
    }
}
