using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirrel4_Move : MonoBehaviour {
    private int loopCount;
    private int upDown;
    public static int score;

    // Use this for initialization
    void Start()
    {
        loopCount = 0;
        upDown = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (loopCount % 183 == 0)
        {
            GoUpDown();
            upDown++;
        }
        loopCount++;
    }

    void GoUpDown()
    {
        if (upDown % 4 == 0)
        {
            gameObject.transform.Translate(0, 23.0f, 0);
        }
        else if (upDown % 4 == 3)
        {
            gameObject.transform.Translate(0, -23.0f, 0);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.Translate(0, -23.0f, 0);
            upDown = -1;
            score++;
        }
    }
}
