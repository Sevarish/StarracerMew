using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentacleManager : MonoBehaviour
{
    BoxCollider boxC;
    Animator anim;
    ParticleSystem ps;
    bool stretch = false;
    bool getNewPos = true;
    float counter = 0;
    float stretchCount = 0;
    float yPos;
    float minIndicate;
    float actualIndicate;
    private bool canPlay = true;
    // Use this for initialization
    void Start()
    {
        boxC = GetComponent<BoxCollider>();
        anim = GetComponent<Animator>();
        ps = GetComponent<ParticleSystem>();
        actualIndicate = Random.Range(5f, 16f);
        minIndicate = actualIndicate - 1.5f;
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        yPos = GameObject.Find("CamPointAndPlayer").GetComponent<Transform>().position.y + Random.Range(-4f, 10f);
        if (counter > minIndicate && canPlay)
        {
            ps.Play();
            canPlay = false;
        }
        if (counter > actualIndicate)
        {
            actualIndicate = Random.Range(4, 10);
            minIndicate = actualIndicate - 1.5f;
            stretch = true;
            counter = 0;
            canPlay = true;
            ps.Stop();
        }
        else if (stretch == false)
        {
            anim.Play("null");
        }

        if (getNewPos == true)
        {
            transform.position = new Vector3(-7, yPos, -3.47f);
            getNewPos = false;
        }



        if (stretch == true)
        {
            stretchCount += Time.deltaTime;
            anim.Play("TentacleAnim");

            if (stretchCount >= 0.2f && stretchCount <= 0.3f)
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
    }
}

