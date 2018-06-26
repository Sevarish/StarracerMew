using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAndStart : MonoBehaviour {
    ParticleSystem ps;
    // Use this for initialization
    void Start () {
        ps = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isPlaying == false)
        {
            ps.Stop();
        }

        
	}
}
