using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeMonster : MonoBehaviour {
    Transform myT;
    bool shakeUp = false;
    bool shakeDown = true;
    int counter = 0;
	// Use this for initialization
	void Start () {
        myT = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (shakeDown == true) {
            myT.transform.Translate(0, -0.01f, 0);
        }
        if (shakeUp == true)
        {
            myT.transform.Translate(0, 0.01f, 0);
        }
        counter++;
        if (counter >= 30)
        {
            counter = 0;
            shakeDown = !shakeDown;
            shakeUp = !shakeUp;
        }

	}
}
