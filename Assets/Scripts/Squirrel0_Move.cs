using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squirrel0_Move : MonoBehaviour
{
    private int loopCount;
    private int upDown;
    public int score;
    int totalScore;
    public Text displayScore;

    // Use this for initialization
    void Start()
    {
        totalScore = 0;
        loopCount = 0;
        upDown = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (loopCount % 200 == 0)
        {
            GoUpDown();
            upDown++;
        }
        loopCount++;
        totalScore = score + Squirrel1_Move.score + Squirrel2_Move.score + Squirrel3_Move.score + Squirrel4_Move.score + Squirrel5_Move.score;
        displayScore.text = "Score: " +totalScore.ToString();
    }

    void GoUpDown()
    {
        if (upDown % 3 == 0)
        {
            gameObject.transform.Translate(0, 23.0f, 0);
        }
        else if (upDown % 3 == 2)
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
