using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public Transform player;    // A reference to the player transform

    // Update is called once per frame
    void Update()
    {

        // Checking if the player position is 10 unit forward than current objects
        if (player.position.y >= (this.transform.position.y + 3f))
        //if (this.transform.position.y <= (player.position.y - 15f))
        {
            // Destroying the current objects
            Destroy(this.gameObject);
        }
    }
}
