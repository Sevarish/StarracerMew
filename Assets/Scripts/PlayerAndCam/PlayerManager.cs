using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class PlayerManager : MonoBehaviour {
    public float shieldTimer = 0.0f;
    public bool isShielded = false;
    bool doOnce = true;
    public bool isHitFinal = false;
    public bool isPlaying = true;
    float count = 0;
    int explosionTimer = 0;
    bool explosionActive = false;
    public int lives = 3;
    bool doOnce1 = true;
    SpriteRenderer spr;
    public Sprite null1;
    Animator anim;
    Animator anim2;

    public CameraShakeScript cameraShake;
    // Use this for initialization
    void Start () {
        anim = GameObject.Find("Explosion").GetComponent<Animator>();
        anim2 = GameObject.Find("Shield").GetComponent<Animator>();
        anim.Play("null");
        anim2.Play("null");
        spr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {




        if (isShielded == true)
        {
            anim2.Play("Shield");
            
            shieldTimer += Time.deltaTime;
            if (shieldTimer > 5.5f && shieldTimer < 7 && doOnce == true)
            {
                GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp -= 20;
                GameObject.Find("rocket fire").GetComponent<StopAndStart>().ps.startSpeed = -7.52f;
                doOnce = false;
            }
            if (shieldTimer >= 7)
            {
                
                isShielded = false;
                GameObject.Find("rocket fire").GetComponent<StopAndStart>().doOnce = true;
                doOnce = true;
                anim2.Play("null");
                
            }
        }

        


        if (isHitFinal == true)
        {
            count += Time.deltaTime;
            spr.sprite = null1;
            isPlaying = false;
            if (doOnce1 == true)
            {
                GameObject.Find("Monster").GetComponent<MonsterSounds>().msNoise.PlayOneShot(GameObject.Find("Monster").GetComponent<MonsterSounds>().Scream1, 1);
                doOnce1 = false;
                CameraShaker.Instance.ShakeOnce(10f, 10f, 3f, 3f);
                
            }
            if (count >= 3.5f)
            {
                Destroy(this.gameObject);
                Application.LoadLevel("DeathScreen");
                isHitFinal = false;
                count = 0;
            }
        }

        if (explosionActive == true)
        {
            explosionTimer++;
            if (explosionTimer == 25)
            {
                explosionTimer = 0;
                explosionActive = false;
                anim.Play("null");
            }
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle" && isShielded == false && lives > 0)
        {
            lives--;
            anim.Play("ExplodeItself");
            explosionActive = true;
            CameraShaker.Instance.ShakeOnce(6f, 6f, 0f, 3f);
        }

        if (collision.gameObject.tag == "Obstacle" && isShielded == false && lives <= 0)
        {
            isHitFinal = true;
            anim.Play("ExplodeItself");
            explosionActive = true;
        }


    }

    
}
