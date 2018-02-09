using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public Transform explosion;

    // This method is called when the player collide with an object
    void OnTriggerEnter2D(Collider2D colliderInfo)  // Get the information about the collision and call it 'collisionInfo'
    {
        // Checking if the player collide with has a tag called 'Obstackle'
        if (colliderInfo.tag == "Planet")
        {
            //// making the player movement to false
            //GetComponent<PlayerMovement>().enabled = false;

            //// Calls the game over method from the gamemanager
            //FindObjectOfType<GameManager>().GameOver();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
