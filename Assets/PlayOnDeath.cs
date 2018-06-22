using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnDeath : MonoBehaviour {
    ParticleSystem pSys;
    bool doOnce = true;
	// Use this for initialization
	void Start () {
        pSys = GetComponent<ParticleSystem>();
        pSys.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Player").GetComponent<PlayerManager>().isHitFinal == true)
        {
            if (doOnce == true)
            {
                pSys.Play();
                doOnce = false;
            }
            
        }
	}
}
