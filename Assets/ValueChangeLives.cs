using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueChangeLives : MonoBehaviour {
    public Slider slider;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	   if (GameObject.Find("Player").GetComponent<PlayerManager>().lives == 3)
        {
            slider.value = 1;
        }
        else if (GameObject.Find("Player").GetComponent<PlayerManager>().lives == 2)
        {
            slider.value = 0.68f;
        }
        else if (GameObject.Find("Player").GetComponent<PlayerManager>().lives == 1)
        {
            slider.value = 0.33f;
        }
        else
        {
            slider.value = 0;
        }
    }
}
