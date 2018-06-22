using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAndStart : MonoBehaviour {
    ParticleSystem ps;
    public bool partSysStop = false;
    bool doOnce = false;
	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isPlaying == true)
        {
            if (partSysStop == true)
            {
                ps.Pause();
                doOnce = true;
            }
            if (partSysStop == false)
            {
                if (doOnce == true)
                {
                    ps.Play();
                    doOnce = false;
                }
            }
        }
        else
        {
            ps.Stop();
        }
	}
}
