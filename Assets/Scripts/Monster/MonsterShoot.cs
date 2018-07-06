using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShoot : MonoBehaviour {
    public GameObject Projectile;
    public GameObject Rocket_Emitter1;
    public GameObject Rocket_Emitter2;
    public GameObject Rocket_Emitter3;
    public GameObject Rocket_Emitter4;
    public GameObject Rocket_Emitter5;
    public GameObject Rocket_Emitter6;
    public bool emit1Active = false;
    public bool emit2Active = false;
    public bool emit3Active = false;
    public bool emit4Active = false;
    public bool emit5Active = false;
    public bool emit6Active = false;
    float force = 3500;
    public bool randActive = true;
    public int counter = 0;
    int rand;
    float indicateTime = 0;
    float shootTime = 0;
    // Use this for initialization
    void Start () {

	}

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerMovement>().myT.position.y < 160)
        {
            if (randActive == true)
            {
                rand = Random.Range(1, 7);
                randActive = false;
     
                indicateTime = Random.Range(60, 360);
                shootTime = indicateTime + Random.Range(80, 90);
            }
            counter++;
            
            if (rand == 1)
            {
                if (counter >= indicateTime)
                {
                    emit1Active = true;
                }
                if (counter == shootTime)
                {

                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(Projectile, Rocket_Emitter1.transform.position, Rocket_Emitter1.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * force);
                    Destroy(Temporary_Bullet_Handler, 1f);

                    counter = 0;
                    randActive = true;
                    emit1Active = false;
                }
            }
            else if (rand == 2)
            {
                if (counter >= indicateTime)
                {
                    emit2Active = true;
                }
                if (counter == shootTime)
                {

                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(Projectile, Rocket_Emitter2.transform.position, Rocket_Emitter2.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * force);
                    Destroy(Temporary_Bullet_Handler, 1f);

                    counter = 0;
                    randActive = true;
                    emit2Active = false;
                }
            }
            else if (rand == 3)
            {
                if (counter >= indicateTime)
                {
                    emit3Active = true;
                }
                if (counter == shootTime)
                {

                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(Projectile, Rocket_Emitter3.transform.position, Rocket_Emitter3.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * force);
                    Destroy(Temporary_Bullet_Handler, 1f);

                    counter = 0;
                    randActive = true;
                    emit3Active = false;
                }
            }
            else if (rand == 4)
            {
                if (counter >= indicateTime)
                {
                    emit4Active = true;
                }
                if (counter == shootTime)
                {

                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(Projectile, Rocket_Emitter4.transform.position, Rocket_Emitter4.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * force);
                    Destroy(Temporary_Bullet_Handler, 1f);

                    counter = 0;
                    randActive = true;
                    emit4Active = false;
                }
            }
            else if (rand == 5)
            {
                if (counter >= indicateTime)
                {
                    emit5Active = true;
                }
                if (counter == shootTime)
                {

                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(Projectile, Rocket_Emitter5.transform.position, Rocket_Emitter5.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * force);
                    Destroy(Temporary_Bullet_Handler, 1f);

                    counter = 0;
                    randActive = true;
                    emit5Active = false;
                }
            }
            else if (rand == 6)
            {
                if (counter >= indicateTime)
                {
                    emit6Active = true;
                }
                if (counter == shootTime)
                {

                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(Projectile, Rocket_Emitter6.transform.position, Rocket_Emitter6.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * force);
                    Destroy(Temporary_Bullet_Handler, 1f);

                    counter = 0;
                    randActive = true;
                    emit6Active = false;
                }
            }


        }
    }
}
