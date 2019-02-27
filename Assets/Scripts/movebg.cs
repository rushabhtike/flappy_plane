using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebg : MonoBehaviour {
    public float speed = 5f;
    planecontroller p;
	// Use this for initialization
	void Start () {
        p = GameObject.Find("planeGreen2").GetComponent<planecontroller>();
	}
	
	// Update is called once per frame
	void Update () {
       if (p.collide == false)
        {
            movebgs();
        }
	}
    void movebgs()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
    }
}
