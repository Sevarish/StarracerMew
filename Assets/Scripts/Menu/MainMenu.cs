using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetFloat("highScore", 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevel()
    {
        Application.LoadLevel("MainScene");
    }
}
