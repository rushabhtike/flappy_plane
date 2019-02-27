using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleloop : MonoBehaviour {

    public float speed = 1.2f;
    planecontroller p;
    // Use this for initialization
    void Start () {
        p = GameObject.Find("planeGreen2").GetComponent<planecontroller>();
    }
	
	// Update is called once per frame
	void Update () {
        if (p.collide == false)
        {
            obstaclesloop();
        }
	}
    void obstaclesloop()
    {
        transform.Translate(-speed*Time.deltaTime, 0, 0);
    }
}
