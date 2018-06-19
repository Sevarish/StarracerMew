using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterShoot : MonoBehaviour {
    public GameObject IndicateSign;
    public GameObject Projectile;
    public GameObject Rocket_Emitter1;
    public GameObject Rocket_Emitter2;
    public GameObject Rocket_Emitter3;
    public GameObject Rocket_Emitter4;
    public GameObject Rocket_Emitter5;
    public GameObject Rocket_Emitter6;
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
     
                indicateTime = Random.Range(60, 420);
                shootTime = indicateTime + 60;
            }
            counter++;
            
            if (rand == 1)
            {
                if (counter >= indicateTime)
                {
                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(IndicateSign, Rocket_Emitter1.transform.position, Rocket_Emitter1.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * 1);
                    Destroy(Temporary_Bullet_Handler, 0.01f);
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
                }
            }
            else if (rand == 2)
            {
                if (counter >= indicateTime)
                {
                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(IndicateSign, Rocket_Emitter2.transform.position, Rocket_Emitter2.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * 1);
                    Destroy(Temporary_Bullet_Handler, 0.01f);
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
                }
            }
            else if (rand == 3)
            {
                if (counter >= indicateTime)
                {
                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(IndicateSign, Rocket_Emitter3.transform.position, Rocket_Emitter3.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * 1);
                    Destroy(Temporary_Bullet_Handler, 0.01f);
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
                }
            }
            else if (rand == 4)
            {
                if (counter >= indicateTime)
                {
                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(IndicateSign, Rocket_Emitter4.transform.position, Rocket_Emitter4.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * 1);
                    Destroy(Temporary_Bullet_Handler, 0.01f);
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
                }
            }
            else if (rand == 5)
            {
                if (counter >= indicateTime)
                {
                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(IndicateSign, Rocket_Emitter5.transform.position, Rocket_Emitter5.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * 1);
                    Destroy(Temporary_Bullet_Handler, 0.01f);
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
                }
            }
            else if (rand == 6)
            {
                if (counter >= indicateTime)
                {
                    GameObject Temporary_Bullet_Handler;
                    Temporary_Bullet_Handler = Instantiate(IndicateSign, Rocket_Emitter6.transform.position, Rocket_Emitter6.transform.rotation) as GameObject;
                    Rigidbody Temporary_RigidBody;
                    Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
                    Temporary_RigidBody.AddForce(transform.up * 1);
                    Destroy(Temporary_Bullet_Handler, 0.01f);
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
                }
            }


        }
    }
}
