using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Transform myT;
    public float speedUp = 8;
    public int speedHor = 9;
    int maxHorRight = 9;
    int maxHorLeft = -9;
    int yPosition = 0;
    public Vector3 resetPoint;
    public Quaternion resetRotation;
    public bool maxHeightReached = false;
    public float x;
    public float y;
    SpriteRenderer render;
    public Sprite normal;
    public Sprite left;
    public Sprite right;
    // Use this for initialization
    

    void Start () {
        myT = transform;
        render = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        resetPoint.x = 0;
        resetPoint.y = 10;
        resetPoint.z = myT.position.z;

        resetRotation.x = 0;
        resetRotation.y = 0;
        resetRotation.z = 0;





        x = Input.GetAxisRaw("Horizontal");

        y = Input.GetAxisRaw("Vertical");

        if (myT.position.x <= maxHorRight && x < 0)
        {
            render.sprite = right;
            transform.Translate(x * Time.deltaTime * -speedHor * 1.5f, 0, 0);
        }
        else if (myT.position.x >= maxHorLeft && x > 0)
        {
            render.sprite = left;
            transform.Translate(x * Time.deltaTime * -speedHor * 1.5f, 0, 0);
        }
        else
        {
            render.sprite = normal;
        }

        if (y > 0 && yPosition <= 50)
        {
            float actualY = y / 6; 
            yPosition++;
            transform.Translate(0 ,actualY, 0);
        }

        if (y < 0 && yPosition >= -10)
        {
            float actualY = y / 6;
            yPosition--;
            transform.Translate(0, actualY, 0);
        }

        


        if (maxHeightReached == true)
        {
            
            speedUp += 0.8f;

            if (GameObject.Find("Player").GetComponent<UI>().distanceCount < 2)
            {
                GameObject.Find("Player").GetComponent<UI>().multValue += 28000;
            }
            else
            {
                GameObject.Find("Player").GetComponent<UI>().multValue += 1500000;
            }

            maxHeightReached = false;
        }

    }
}
