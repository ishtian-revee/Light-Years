using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;    // A refference to the player's transform

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Setting the camera position to behind the player forever
        transform.position = new Vector3(transform.position.x, player.position.y + 1.2f, -5);
    }
}
