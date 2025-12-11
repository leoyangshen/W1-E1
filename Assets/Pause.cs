using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool paused = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
            }
    }
}
