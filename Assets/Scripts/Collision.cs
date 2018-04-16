using UnityEngine;

public class Collision : MonoBehaviour {
    public PlayerMovement off;
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            off.enabled = false;
            FindObjectOfType<GameManger>().Endgame();
        }
    }
}
