using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class MonsterSounds : MonoBehaviour {
    public AudioSource msNoise;
    float counter = 0;
    float timeForCounter;
    bool createNewTime = true;
    public AudioClip Scream1;
    public CameraShakeScript cameraShake;
    // Use this for initialization
    void Start () {
        msNoise = GetComponent<AudioSource>();
        msNoise.Stop();
	}
	
	// Update is called once per frame
	void Update () {
        
        counter += Time.deltaTime;
		if (createNewTime == true)
        {
            createNewTime = false;
            timeForCounter = Random.Range(10.5f, 30.5f);
        }

        if (counter >= timeForCounter)
        {
            CameraShaker.Instance.ShakeOnce(3f, 5f, 2f, 3f);
            msNoise.PlayOneShot(Scream1, 1);
            createNewTime = true;
            counter = 0;

        }
	}
}
