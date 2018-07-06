using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAndStart : MonoBehaviour {
    public ParticleSystem ps;
    public bool doOnce = true;
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
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == true && doOnce == true)
        {
            ps.startSpeed = -17.5f;
            doOnce = false;
        }

        
	}
}
