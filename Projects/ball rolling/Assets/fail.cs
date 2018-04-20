using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fail : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "ball")
        {
            //GameObject.Find("game maneger").SendMessage("RestartGame");
            //GameObject gm = GameObject.Find("game maneger");
            //gamemaneger gmComponent = gm.GetComponent<gamemaneger>();
            gamemaneger gmComponent = GameObject.Find("game maneger").GetComponent<gamemaneger>();
            gmComponent.RestartGame();
            
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gamemaneger gmComponent = GameObject.Find("game maneger").GetComponent<gamemaneger>();
        Debug.Log(gmComponent.coinCount);
    }
}
