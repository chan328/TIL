using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour {
    Vector3 target;
	// Use this for initialization
	void Start ()
    {
        target = GameObject.Find("ball").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
        transform.Rotate(new Vector3(0, 0, 5));
	}
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "ball")
        {
            gamemaneger gmComponent = GameObject.Find("game maneger").GetComponent<gamemaneger>();
            gmComponent.RestartGame();

        }
    }
}
