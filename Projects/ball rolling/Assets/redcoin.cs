using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redcoin : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ball")
        {
            destroyobstacles();
            Destroy(gameObject);
        }
    }
    void destroyobstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("obstacle");
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i].gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
