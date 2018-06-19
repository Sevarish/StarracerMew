using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonasterArmsStretch : MonoBehaviour{

    public GameObject Arm1;
    Transform myArm;
    public float speed;
    int rand;
    int counter = 0;
    int counter2 = 0;
    float growTime = 0.0001f;
    int shrinkTime;
    bool growing = true;
  
    
   
    Vector3 spawnPos;

    private void Start()
    {
        myArm = transform;
        speed = 5;

    }

    void Update()
    {
        myArm.Translate(0, speed * Time.deltaTime, 0);
        counter++;
        counter2++;
        Debug.Log(counter2);
        // armen laten groeien
        if (growing == true)
        {
            growTime += 0.0005f;
            Arm1.transform.localScale += new Vector3(growTime, 0, 0);
           
            if(counter == 150)
            {
                growing = false;
                counter = 0;
            }
        }
        else if(growing == false){
            Arm1.transform.localScale -= new Vector3(growTime, 0, 0);

            growTime += 0.0005f;

            if (counter == 100)
            {
                growing = true;
                counter = 0;
                growTime = 0;
            }
        }
        //Armen omhoog en omlaag laten bewegen
        if (counter2 == 1)
        {
            speed = 1.5f;
            myArm.Translate(0, speed * Time.deltaTime, 0);
        }
        else if (counter2 == 400)
        {
            speed = -1.5f;
            myArm.Translate(0, speed * Time.deltaTime, 0);

        }
        else if (counter2 == 800)
        {
            counter2 = 0;
        }

    }

  
}