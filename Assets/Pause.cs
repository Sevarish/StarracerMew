using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
   public bool isPaused = false;

    public void PauseButton()
    {
        if (isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
        else if (isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
