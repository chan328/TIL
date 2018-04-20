using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    bool ShouldPrintOver20 = true;
    bool ShouldPrintOver30 = true;
    float StartngPoint;
    int count = 1;
    SphereCollider mycollider;
    // Use this for initialization
    void Start()
    {
        Debug.Log("일련번호: " + GetInstanceID());
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        Debug.Log("use gravity?"+myRigidbody.useGravity);
        Debug.Log("start");
        StartngPoint = transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
            //빼는 순간은 GetKeyup을 사용 눌려있는 동안은 GetKey를 사용.
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
        }
        float distance;
        distance = transform.position.z - StartngPoint;
        
        if (distance > 30)
        {
            if (ShouldPrintOver30)
            {
                Debug.Log("over 30:" + distance);
                ShouldPrintOver30 = false;
            }
            
        }
        else if(distance >20)
        {
            if (ShouldPrintOver20)
            {
                Debug.Log("over 20:" + distance);
                ShouldPrintOver20 = false;
            }
        }
	}
}