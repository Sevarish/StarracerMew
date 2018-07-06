using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEmit : MonoBehaviour {
    ParticleSystem ps;
    Transform myT;
    float monsterPos;
    bool doOnce = true;
	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        myT = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        monsterPos = GameObject.Find("Monster").GetComponent<Transform>().position.y;
		if (GameObject.Find("Monster").GetComponent<MonsterShoot>().emit1Active == true)
        {
            myT.transform.position = new Vector3(0, monsterPos - 3.81f, -3.47f);
            if (doOnce == true)
            {
                ps.Play();
                doOnce = false;
            }
            
        }
        else if (GameObject.Find("Monster").GetComponent<MonsterShoot>().emit2Active == true)
        {
            myT.transform.position = new Vector3(1.69f, monsterPos - 2.04f, -3.47f);
            if (doOnce == true)
            {
                ps.Play();
                doOnce = false;
            }
        }
        else if (GameObject.Find("Monster").GetComponent<MonsterShoot>().emit3Active == true)
        {
            myT.transform.position = new Vector3(5.77f, monsterPos - 1.5f, -3.47f);
            if (doOnce == true)
            {
                ps.Play();
                doOnce = false;
            }
        }
        else if (GameObject.Find("Monster").GetComponent<MonsterShoot>().emit4Active == true)
        {
            myT.transform.position = new Vector3(-2.13f, monsterPos - 2.71f, -3.47f);
            if (doOnce == true)
            {
                ps.Play();
                doOnce = false;
            }
        }
        else if (GameObject.Find("Monster").GetComponent<MonsterShoot>().emit5Active == true)
        {
            myT.transform.position = new Vector3(-4.98f, monsterPos - 1.77f, -3.47f);
            if (doOnce == true)
            {
                ps.Play();
                doOnce = false;
            }
        }
        else if (GameObject.Find("Monster").GetComponent<MonsterShoot>().emit6Active == true)
        {
            myT.transform.position = new Vector3(-7.45f, monsterPos - 1.25f, -3.47f);
            if (doOnce == true)
            {
                ps.Play();
                doOnce = false;
            }
        }
        else
        {
            ps.Stop();
            doOnce = true;

        }
    }
}
