using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPosition : MonoBehaviour
{
    private Vector2 pos;
    private Vector2 MousePos;
    float dist = 0;
    int MouseCount = 0;

    void Start()
    {
            Debug.Log("New game");
            float x = Random.Range(0, 450);
            float y = Random.Range(0, 450);
            pos = new Vector2(x, y);
            transform.position = pos;
            MouseCount = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Mouse0)) 
        {
            ++MouseCount;
            MousePos = Input.mousePosition;
            // Debug.Log(MousePos);

            if (dist < 20.0f)
            {
                Debug.Log("Win! Your score: " + MouseCount + ". Press R to start new game");
            } else if (dist < 50.0f)
            {
                Debug.Log("Very Hot");
            } else if (dist < 75.0f)
            {
                Debug.Log("Hot");
            } else if (dist < 100.0f)
            {
                Debug.Log("Cold");
            } else if (dist < 150.0f)
            {
               Debug.Log("Very Cold");
            } else if (dist > 200.0f)
            {
                Debug.Log("Freeze");
            }
        }

        dist = Vector2.Distance(pos, MousePos);
        // Debug.Log(dist);

        if (Input.GetKeyDown(KeyCode.R))
        {
            Start();
        }
    }
}
