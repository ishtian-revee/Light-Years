using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Vector3 direction;
    private Vector3 leftDiagonal;
    private Vector3 rightDiagonal;

    // Use this for initialization
    void Start () {

        leftDiagonal = new Vector3(-2, 1, 0);
        rightDiagonal = new Vector3(2, 1, 0);
        direction = rightDiagonal;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
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

        float amountToMove = speed * Time.deltaTime;
        transform.Translate(direction * amountToMove);
    }
}
