using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Transform background1;       // referrence to the background texture 1
    public Transform background2;       // referrence to the background texture 2
    public new Transform camera;        // referrence to the main camera

    private bool current = true;

    private float currentHeight = 12.95f;
    private float fixedHeight = 12.95f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (currentHeight < camera.position.y)
        {
            if (current)
            {
                background1.localPosition = new Vector3(0, background1.localPosition.y + (fixedHeight * 2), 0);
            }
            else
            {
                background2.localPosition = new Vector3(0, background2.localPosition.y + (fixedHeight * 2), 0);
            }

            currentHeight += fixedHeight;

            current = !current;
        }

        if (currentHeight > (camera.position.y + fixedHeight))
        {
            if (current)
            {
                background2.localPosition = new Vector3(0, background2.localPosition.y - (fixedHeight * 2), 0);
            }
            else
            {
                background1.localPosition = new Vector3(0, background1.localPosition.y - (fixedHeight * 2), 0);
            }

            currentHeight -= fixedHeight;

            current = !current;
        }
    }
}
