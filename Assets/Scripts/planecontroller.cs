using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class planecontroller : MonoBehaviour {
    Rigidbody2D rb;
    public bool collide = false;
   // public Button myButton;
    
  	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        //Button btn = myButton.GetComponent<Button>();
       // btn.onClick.AddListener(TaskOnClick);    

    }


    // Update is called once per frame
    void Update()
    {
        if (collide == false)
        {
            if (Input.GetMouseButtonDown(0) || Input.anyKeyDown)
            {
                rb.velocity = new Vector2(0, 3);
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "testObstacles")
        {
            collide = true;
            SceneManager.LoadScene("start");
        }
        
    }
    private void FixedUpdate()
    {

        if (rb.velocity.y > 0)
        {
            float angle = Mathf.Lerp(0, 45, rb.velocity.y / 2f);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else if (rb.velocity.y < 0)
        {
            float angle = Mathf.Lerp(0, -45, -rb.velocity.y / 2f);
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        if (rb.velocity.y == 0)
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
   /* private void OnBecameInvisible()
    {
        SceneManager.LoadScene("start");
    }/*
    public void TaskOnClick()
    {
        SceneManager.LoadScene("Menu");
    }*/
    
}
