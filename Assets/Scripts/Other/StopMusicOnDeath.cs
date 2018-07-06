using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusicOnDeath : MonoBehaviour {
    AudioSource au;
	// Use this for initialization
	void Start () {
        au = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Player").GetComponent<PlayerManager>().isPlaying == false)
        {
            au.Stop();
        }
	}
}
