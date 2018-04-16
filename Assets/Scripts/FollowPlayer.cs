using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;

	// Update is called once per frame
	void Update () {
        transform.position = player.position + new Vector3(4, 3, 0);
        if(player.position.y<1)
        {
            FindObjectOfType<GameManger>().Endgame();
        }
	}
}
