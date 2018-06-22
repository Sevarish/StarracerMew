using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPointMaxHeight : MonoBehaviour {
    Transform myT;
    
	// Use this for initialization
	void Start () {
        myT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isPlaying == true)
        {
            myT.Translate(0, GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * Time.deltaTime, 0);
        }
        if (GameObject.Find("Player").GetComponent<PlayerMovement>().myT.position.y >= 180)
        {
            GameObject.Find("Player").GetComponent<PlayerMovement>().maxHeightReached = true;
        }
        if (GameObject.Find("Player").GetComponent<PlayerMovement>().myT.position.y >= 10)
        {
            GameObject.Find("rocket fire").GetComponent<StopAndStart>().partSysStop = false;
        }
        if (GameObject.Find("Player").GetComponent<PlayerMovement>().myT.position.y >= 179)
        {
            GameObject.Find("rocket fire").GetComponent<StopAndStart>().partSysStop = true;
        }

        if (GameObject.Find("Player").GetComponent<PlayerMovement>().maxHeightReached == true)
        {
            myT.SetPositionAndRotation(GameObject.Find("Player").GetComponent<PlayerMovement>().resetPoint, GameObject.Find("Player").GetComponent<PlayerMovement>().resetRotation);
        }
    }
}
