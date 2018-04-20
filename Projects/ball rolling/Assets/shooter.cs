using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : obstacle {
    public GameObject stone;

   
    float delta = 0;
    // Use this for initialization
    void Start()
    {

    }

    float timecount = 0;
    // Update is called once per frame
    void Update()
    {
        timecount += Time.deltaTime;
        if (timecount > 3)
        {
            Instantiate(stone, transform.position, Quaternion.identity);
            timecount = 0;
        }
        float newXpostion = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newXpostion,
        transform.localPosition.y,
        transform.localPosition.z);
        if (transform.localPosition.x < -3.5)
        {
            delta = 0.1f;
        }
        else if (transform.localPosition.x > 3.5)
        {
            delta = -0.1f;
        }
    }
}