using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterArms : MonoBehaviour {
    float stretchPerUpdate = 0.2f;
    float actualStretch = 1;
    float maxStretch = 23f;
    float minStretch = 1f;
    float acKm;
    float acStretch;
   // float minVerticalPos = -1f;
   // float maxVerticalPos = 10f;
    bool allowStretch = true;
    bool allowShrink = false;
    public GameObject arm1;
	
	// Update is called once per frame
	void Update () {
        if (acStretch <= 6)
        {
            acKm = GameObject.Find("Player").GetComponent<UI>().kmUp;
            acStretch = acKm / 10000000000 + 0.2f;
        }
        stretchPerUpdate = Random.Range(0.0002f, acStretch);

        if (arm1.transform.localScale.x >= maxStretch)
        {
            allowShrink = true;
            allowStretch = false;
        }
        if (arm1.transform.localScale.x <= minStretch)
        {
            allowShrink = false;
            allowStretch = true;
        }

        if (allowStretch == true)
        {
            actualStretch += stretchPerUpdate;
            arm1.transform.localScale = new Vector3(actualStretch,1,1);
        }

        if (allowShrink == true)
        {
            actualStretch -= stretchPerUpdate;
            arm1.transform.localScale = new Vector3(actualStretch, 1, 1);
        }

        if (actualStretch < 1.5f)
        {
            float spawnPos = GameObject.Find("CamPointAndPlayer").GetComponent<Transform>().position.y + Random.Range(-4f, 10f);
            transform.position = new Vector3(15, spawnPos, -3.47f);
        }




	}
}
