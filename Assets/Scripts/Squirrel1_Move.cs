using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirrel1_Move : MonoBehaviour {
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
        if (loopCount % 60 == 0)
        {
            GoUpDown();
            upDown++;
        }
        loopCount++;
    }

    void GoUpDown()
    {
        if (upDown % 5 == 0)
        {
            gameObject.transform.Translate(0, 23.0f, 0);
        }
        else if (upDown % 5 == 4)
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
