using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgcontroller : MonoBehaviour {

    public GameObject obj1;
    public GameObject obj_position;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bgss")
        {
            Instantiate(obj1, obj_position.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
        }
    }
}
