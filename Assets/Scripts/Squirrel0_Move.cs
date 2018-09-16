using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squirrel0_Move : MonoBehaviour
{
    private int loopCount;
    private int upDown;
    private float speed;
    public Text displayLoops;

    // Use this for initialization
    void Start()
    {
        loopCount = 0;
        upDown = 0;
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (loopCount % 100 == 0)
        {
            GoUpDown();
            upDown++;
        }
        loopCount++;
        displayLoops.text = "Loops: " + loopCount.ToString();
    }

    void GoUpDown()
    {
        if (upDown % 3 == 0)
        {
            gameObject.transform.Translate(0, 10.0f, 0);
        }
        else if (upDown % 3 == 2)
        {
            gameObject.transform.Translate(0, -10.0f, 0);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseDown(0))
        {

        }
    }
}
