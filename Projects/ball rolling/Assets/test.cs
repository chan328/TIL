using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("ball");

        GameObject[] coins = GameObject.FindGameObjectsWithTag("coin");


        for (int i = 0; i < coins.Length; i++)// 1번째는 반복문 준비 2분째는 반복문 실행 조건 3번째는 실행후의 코드.
        {
            Debug.Log(coins[i].name);
        }
        //GameObject[] coins = GameObject.FindGameObjectsWithTag("coin");
        // findgameobjectswithtag는 "n"이라는 태그를 가진걸 다 가져옴!
        //Debug.Log(coins[0].name);
    }
	
	// Update is called once per frame
	void Update () {

		
        transform.position = new Vector3(
            0, ball.transform.position.y + 3
            , ball.transform.position.z - 14);
	}
}
