using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Img : MonoBehaviour {
    public RawImage imgr;
    public Texture one;
        public Texture two;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        imgr.texture = one;
	}
}
