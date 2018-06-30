using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleManager : MonoBehaviour {
    BoxCollider boxC;
    Animator anim;
    public GameObject emitSignal;
    public GameObject emitter;
    bool stretch = false;
    bool getNewPos = true;
    float counter = 0;
    float stretchCount = 0;
    float yPos;
    float minIndicate;
    float actualIndicate;
    // Use this for initialization
    void Start () {
        boxC = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        actualIndicate = Random.Range(5f, 16f);
        minIndicate = actualIndicate - 1.3f;
    }
	
	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;
        yPos = GameObject.Find("CamPointAndPlayer").GetComponent<Transform>().position.y + Random.Range(-4f, 10f);
        if (counter > actualIndicate)
        {
            actualIndicate = Random.Range(5f, 16f);
            minIndicate = actualIndicate - 1.3f;
            stretch = true;
            counter = 0;
        }
        if (counter > minIndicate && counter < actualIndicate)
        {
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(emitSignal, emitter.transform.position, emitter.transform.rotation) as GameObject;
            Rigidbody Temporary_RigidBody;
            Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Temporary_RigidBody.AddForce(transform.up * 1);
            Destroy(Temporary_Bullet_Handler, 0.01f);
        }

        if (getNewPos == true)
        {
            transform.position = new Vector3(-7, yPos, -3.47f);
            getNewPos = false;
        }



        if (stretch == true)
        {
            stretchCount += Time.deltaTime;
            anim.Play("TentacleAnim"); if (stretchCount >= 0.2f && stretchCount <= 0.28f)
            {
                boxC.size = new Vector3(4, 1, 1);
            }
            if (stretchCount > 0.28f && stretchCount < 0.4f)
            {
                boxC.size = new Vector3(8, 1, 1);
            }
            else
            {
                boxC.size = new Vector3(12, 1, 1);
            }
            if (stretchCount >= 0.5f)
            {
                boxC.size = new Vector3(0, 0, 0);
                stretchCount = 0;
                stretch = false;
                getNewPos = true;
            }
        }
        else
        {
            anim.Play("null");
        }
	}
}

