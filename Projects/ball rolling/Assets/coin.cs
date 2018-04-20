using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "ball")
        {
            GameObject.Find("game maneger").SendMessage("GetCoin");
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
