using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveturn : MonoBehaviour {
    Vector3 foward = new Vector3(0, 0, 1);
    Vector3 up = new Vector3(0, 1, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        v = v * Time.deltaTime;
        h = h * Time.deltaTime;

        transform.Translate(foward * v * 20);
        transform.ro
	}
}
