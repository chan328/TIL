﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = (new Vector3(10,0,zRotation));

        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            Debug.Log("mouse down" + Input.mousePosition);
            if(Input.mousePosition.x<Screen.width/2)
            {
                transform.localEulerAngles = new Vector3(
                    10, 0, transform.localEulerAngles.z + 1);
                //왼쪽 클릭
            }
            else
            {
                transform.localEulerAngles = new Vector3(
                   10, 0, transform.localEulerAngles.z - 1);
                //오른쪽 클릭
            }
        }
	}
}
