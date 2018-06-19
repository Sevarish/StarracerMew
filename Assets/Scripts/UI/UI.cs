using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public RawImage imgr;
    public Texture one;
    public Texture two;
    public Texture three;
    public Texture four;
    public Texture five;
    public Texture six;
    public Texture seven;

    public Text distanceUpText;
    public Text nearestPlanetText;
    public Text shieldText;
    public float kmUp = 0f;
    public float distanceFromNearestPlanet;
    public float[] distanceFromArray = {41400000f, 78340000f, 91691000f, 628730000f, 1275000000f, 2723950000f, 4351400000f};
    public string[] planetName = { "Venus", "Mars", "Mercury", "Jupiter", "Saturn", "Uranus", "Neptune"};
    public int distanceCount = 0;
    public long multValue = 50000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float actualDistanceFromPlanet = distanceFromArray[distanceCount] - kmUp;
        kmUp += GameObject.Find("Player").GetComponent<PlayerMovement>().speedUp * multValue * Time.deltaTime;
        float kmUpActual = Mathf.Round(kmUp);
        string kmUpString = kmUpActual.ToString("n0");
        nearestPlanetText.text = "Nearest Planet: \n" + planetName[distanceCount] + "\n\nDistance Remaining: \n" +  actualDistanceFromPlanet;
        distanceUpText.text = kmUpString + " KM";
        if (kmUp >= distanceFromArray[distanceCount] && distanceCount < 6)
        {
            distanceCount++;
        }

        if (kmUp >= 4351400000f)
        {
            nearestPlanetText.text = "Beyond Neptune";
        }

        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == true)
        {
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 1)
            {
                shieldText.text = "Shield: llllll";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 2 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 1)
            {
                shieldText.text = "Shield: lllll";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 3 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 2)
            {
                shieldText.text = "Shield: llll";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 4 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 3)
            {
                shieldText.text = "Shield: lll";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 5 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 4)
            {
                shieldText.text = "Shield: ll";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 6 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 5)
            {
                shieldText.text = "Shield: l ";
            }
            if (GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer < 7 && GameObject.Find("Player").GetComponent<PlayerManager>().shieldTimer > 6)
            {
                shieldText.text = "Shield: ";
            }

        }
        if (GameObject.Find("Player").GetComponent<PlayerManager>().isShielded == false)
        {
            shieldText.text = "Shield Inactive";
        }
        switch (distanceCount)
        {

            case 0:
                imgr.texture = one;


                break;
            case 1:
                imgr.texture = two;

                break;
            case 2:
                imgr.texture = three;


                break;
            case 3:
                imgr.texture = four;

                break;
            case 4:
                imgr.texture = five;

                break;
            case 5:
                imgr.texture = six;

                break;
            case 6:
                imgr.texture = seven;

                break;
            default:
                
                break;
        }


    }
}
