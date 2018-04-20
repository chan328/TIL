using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arraytest : MonoBehaviour {
    int student1;
    int student2;
    int student3;
    int student4;
    // ....
    int student30;

    int[] students = new int[30]; // 타입 변수명 = 길이
	// Use this for initialization
	void Start () {
        student30 = 90;
        Debug.Log(student30);

        students[0] = 87;
        Debug.Log(students[0]);//첫번째 수는 0부터 시작함!그리고 배열 마지막수 n-1인거임!

        Debug.Log(students[29]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
