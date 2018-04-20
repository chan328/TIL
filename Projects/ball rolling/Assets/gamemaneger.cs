using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemaneger : MonoBehaviour {
    public Text cointext;
    public int coinCount = 0;
    void GetCoin()
    {
        coinCount++;
        cointext.text = coinCount + "개";
        Debug.Log("동전: " + coinCount);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("game");
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
