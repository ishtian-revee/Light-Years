using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;             // players speed
    private Vector3 direction;      // movement directions
    private Vector3 leftDiagonal;
    private Vector3 rightDiagonal;

    // Use this for initialization
    void Start () {

        leftDiagonal = new Vector3(-2, 1, 0);
        rightDiagonal = new Vector3(2, 1, 0);
        direction = rightDiagonal;              // initially direction is in right diagonal
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // direction changes for key inputs
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (direction == leftDiagonal)
            {
                direction = rightDiagonal;
            }
            else
            {
                direction = leftDiagonal;
            }
        }

        // movement amount calculations and changes for each frames
        float amountToMove = speed * Time.deltaTime;
        transform.Translate(direction * amountToMove);
    }
}
